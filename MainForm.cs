using DB_SYNC3.Models;
using DB_SYNC3.Models.DTO;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Data.Entity.Infrastructure.Design.Executor;


namespace DB_SYNC3
{
    public partial class MainForm : Form
    {
        string sourceConnStr = "Server=localhost\\SQLEXPRESS;Database=CMS;User Id=sa;Password=Magical9070;";
        private MyDbContext _db;
        private DateTime? _lastDate;
        bool _isSorting = false;
        private string lastSortedColumn = "";
        private bool sortAscending = true;
        public MainForm()
        {
            InitializeComponent();
            _db = new MyDbContext();
        }

        /// <summary>
        /// 測試本機連線
        /// </summary>
        /// <param name="connStr"></param>
        /// <returns></returns>
        private bool TestLocal_Connection(string connStr)
        {
            messageRecord("連線中");

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    //conn.Open();
                    _db.Database.Connection.Open();
                    lbl_Source_Status.Text = "來源資料庫：";
                    lbl_Val_Source_Status.Text = "已連線";
                    lbl_Val_Source_Status.ForeColor = Color.Green;

                
                    messageRecord("本機連線成功");

                    GetLocalDB();
                    return true;
                }
                catch (Exception ex)
                {
                    lbl_Source_Status.Text = "來源資料庫："  ;
                    lbl_Val_Source_Status.Text = "連線失敗 ";
                    lbl_Val_Source_Status.ForeColor = Color.Red;

                    messageRecord(ex.Message);

                    return false;
                }
            }
        }

        /// <summary>
        /// 顯示執行狀懬
        /// </summary>
        /// <param name="message"></param>
        public void messageRecord(string message)
        {
            string datePrefix = DateTime.Now.ToString("yyyy/MM/dd HH:mm") + " ";
            lbx_msg.Items.Add("●"+datePrefix);
            // 固定每 40 個字切一行
            for (int i = 0; i < message.Length; i += 40)
            {
                string line = message.Substring(i, Math.Min(40, message.Length - i));
                lbx_msg.Items.Add(line);
                // 新增資料後
                lbx_msg.TopIndex = lbx_msg.Items.Count - 1;

            }
        }

        /// <summary>
        /// 取得本機資料表
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void GetLocalDB()
        {

            using (SqlConnection conn = new SqlConnection(sourceConnStr))
            {

                //取得所有社區清單
                var communities = _db.Comms.ToList();
                foreach(comm tt in communities)
                {
                    var key = $"{tt.ano}_{tt.cno}";
                    var value = $"{tt.ano}{tt.cno}_{tt.cname}";

                    clb_communies.Items.Add(new KeyValuePair<string, string>(key, value));
                    lstTables.Items.Add(value);
                }
                clb_communies.DisplayMember = "Value"; // 顯示的文字
                clb_communies.ValueMember = "Key";     // 內部的實際值
                return;
                conn.Open();

                // 取得資料表清單
                DataTable DB = conn.GetSchema("Tables");
                // custom 在最上方
                // 假設要篩選包含 "custom" 或 "comm" 或 "maintain" 的表
                string[] keywords = { "custom", "comm", "maintain" };

                var matchedTables = DB.Rows.Cast<DataRow>()
                    .Where(r => r["TABLE_NAME"] != DBNull.Value &&
                                keywords.Any(k => r["TABLE_NAME"].ToString()
                                                    .IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0))
                    .ToList();

                if (matchedTables.Any())
                {
                    lstTables.Items.Add("--更新資料表--");
                    foreach (var row in matchedTables)
                    {
                        string schema = row["TABLE_SCHEMA"].ToString();
                        string tableName = row["TABLE_NAME"].ToString();
                        lstTables.Items.Add($"{schema}.{tableName}");
                    }
                }

                // 其他資料表
                //var otherTables = DB.Rows.Cast<DataRow>()
                //    .Where(r => !r["TABLE_NAME"].ToString().Equals("custom", StringComparison.OrdinalIgnoreCase))
                //    .OrderBy(r => r["TABLE_NAME"].ToString()) // 排序比較美觀
                //    .ToList();

                //if (otherTables.Any())
                //{
                //    lstTables.Items.Add("--其他資料表--");
                //    foreach (var row in otherTables)
                //    {
                //        string schema = row["TABLE_SCHEMA"].ToString();
                //        string tableName = row["TABLE_NAME"].ToString();
                //        lstTables.Items.Add($"{schema}.{tableName}");
                //    }
                //}


            }

        }
        /// <summary>
        /// 遠端連線
        /// </summary>
        public async Task<bool> GetLastDatetime()
        {
            string apiUrl = "https://communitynet.renthouse.app/api/comm/lastdate";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = await client.GetStringAsync(apiUrl);

                    // 解析 JSON
                    JObject obj = JObject.Parse(response);
                    _lastDate = obj["lastDate"].ToObject<DateTime>();
                    lst_Target.Items.Clear();
                    lst_Target.Items.Add("最新資料：" + _lastDate);

                    lbl_TargetStatus.Text = "目的資料庫：";
                    lbl_Val_TargetStatus.Text = "已連線";
                    lbl_Val_TargetStatus.ForeColor = Color.Green;

                    messageRecord("API 最後日期：" + _lastDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));

                    return true;
                }
            }
            catch (Exception ex)
            {
                lbl_TargetStatus.Text = "目的資料庫：";
                lbl_Val_TargetStatus.Text = "連線失敗";
                lbl_Val_TargetStatus.ForeColor =Color.Red;

                messageRecord("讀取 API 錯誤: " + ex.Message);

                return false;
            }
        }

        private async  void btn_ConnectTest_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestConnection();
        }
        /// <summary>
        /// 開始同步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sync_Click(object sender, EventArgs e)
        {
            lst_Target.Items.Clear();
            lst_Target.Items.Add("最新資料：" + _lastDate);

            string url = "https://communitynet.renthouse.app/api/custom/receive";

            try
            {
                string dateStr = "2025-06-06";
                DateTime lastDate = DateTime.Parse(dateStr);  // C# 先解析

                var tmpCustom = _db.custom.Where(x => x.m_date > lastDate).ToList();
                messageRecord($"✅ 查詢結果: custom={tmpCustom.Count}");


                var tmpComm = _db.Comms.Where(x => x.m_date > lastDate).ToList();
                messageRecord($"✅ 查詢結果: comm={tmpComm.Count}");

                var tmpMaintain = _db.maintain.Where(x => x.m_date > lastDate).ToList();
                messageRecord($"✅ 查詢結果: maintain={tmpMaintain.Count}");


                messageRecord("--ST取得m_date數量--");

                //  PostAPI(_lastDate);
                PostMultiTableDataAsync(_lastDate);
            }
            catch (Exception ex)
            {
                // 顯示完整錯誤
                string fullError = $"錯誤訊息: {ex.Message}\n\n"
                                 + $"InnerException: {ex.InnerException?.Message}\n\n"
                                 + $"StackTrace:\n{ex.StackTrace}";

                tbx_APIJSON.Text += fullError ;
                messageRecord(fullError);
            }
        }

        public async Task PostMultiTableDataAsync(DateTime? lastDate)
        {
            messageRecord("--ST PostMultiTableDataAsync--" + lastDate);

            // 1️⃣ 檢查資料庫連線
            try
            {
                if (!_db.Database.Exists())
                {
                    messageRecord("❌ 資料庫不存在或無法連線");
                    return;
                }
                messageRecord("✅ _db.Database.Exists() = true");
            }
            catch (Exception ex)
            {
                messageRecord("❌ 資料庫檢查失敗：" + ex.Message);
                return;
            }

            // 2️⃣ 查詢各資料表
            messageRecord("--ST 查詢各資料表--");

            List<custom> tmpCustom = null;
            List<maintain> tmpMaintain = null;
            List<comm> tmpComm = null;

            try
            {
             
                tmpCustom = _db.custom.Where(x => x.m_date > lastDate).ToList();
                messageRecord($"✅ 查詢結果: custom={tmpCustom.Count}");

                tmpComm = _db.Comms.Where(x => x.m_date > lastDate).ToList();
                messageRecord($"✅ 查詢結果: comm={tmpComm.Count}");

                tmpMaintain = _db.maintain.Where(x => x.m_date > lastDate).ToList();
                messageRecord($"✅ 查詢結果: maintain={tmpMaintain.Count}");

            }
            catch (Exception ex)
            {
                messageRecord("❌ 查詢資料表失敗：" + ex.Message);
                tbx_APIJSON.Text = tbx_APIJSON.Text  + ex.Message + ex.InnerException.Message;
                return;
            }

            // 3️⃣ 組成封裝物件
            messageRecord("--ST 組成封裝物件--");
            var payload = new SyncDataDto
            {
                CustomList = tmpCustom,
                maintain = tmpMaintain,
                comm = tmpComm
            };

            UploadInBatches(payload, 5); //一批處理幾位
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Dto">來源資料</param>
        /// <param name="batchSize">一次處理幾筆param>
        /// <returns></returns>
        async Task UploadInBatches(SyncDataDto Dto , int batchSize)
        {
            Dto.CustomList = Dto.CustomList != null ? Dto.CustomList : new List<custom>();
            Dto.maintain = Dto.maintain != null ? Dto.maintain : new List<maintain>();
            Dto.comm = Dto.comm != null ? Dto.comm : new List<comm>();


            var total = Math.Max(Math.Max(Dto.CustomList.Count, Dto.maintain.Count), Dto.comm.Count);
            var totalBatches = (int)Math.Ceiling((double)total / batchSize);
           // totalBatches = 1; //分幾批處理
            for (int i = 0; i < totalBatches; i++)
            {
                // 分批取出
                var batchCustom = Dto.CustomList.Skip(i * batchSize).Take(batchSize).ToList();
                var batchMaintain = Dto.maintain.Skip(i * batchSize).Take(batchSize).ToList();
                var batchComm = Dto.comm.Skip(i * batchSize).Take(batchSize).ToList();

                var payload = new SyncDataDto
                {
                    CustomList = batchCustom,
                    maintain = batchMaintain,
                    comm = batchComm
                };

                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                };
                options.Converters.Add(new DateTimeToDateOnlyConverter());
            
                var json = JsonSerializer.Serialize(payload, options);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // 顯示真正的 JSON
                tbx_APIJSON.Text += "content_tmp JSON: " + await content.ReadAsStringAsync();
              

                messageRecord($"🚀 傳送第 {i + 1}/{totalBatches} 批...");
                var jsonString = await content.ReadAsStringAsync();
                tbx_APIJSON.Text += "content_tmp JSON: " + jsonString;
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        var response = await httpClient.PostAsync("https://communitynet.renthouse.app/api/syncdata/main_syncdata", content);

                        if (response.IsSuccessStatusCode)
                        {
                            messageRecord($"    ✅ 第 {i + 1}/{totalBatches} 批傳送成功");
                        }
                        else
                        {
                            var error = await response.Content.ReadAsStringAsync();
                            messageRecord($"    ❌ 第 {i + 1}/{totalBatches} 批失敗: {response.StatusCode} / {error}");
                            tbx_APIJSON.Text += error;
                        }
                    }
                }
                catch (Exception ex)
                {

                    var error = $"    ❌ 第 {i + 1}/{totalBatches} 批發送錯誤: {ex.Message}";
                    messageRecord(error);
                    tbx_APIJSON.Text += error;
                }

                // 避免連線被阻擋，可稍作延遲
                await Task.Delay(500);
            }
        }

        public async Task PostAPI(DateTime? lastDate)
        {
            var tmp = _db.custom
                .Where(x => x.m_date > lastDate)
                .ToList();
            lst_Target.Items.Add("要更新資料統計=" + tmp.Count());
            messageRecord("要更新資料統計" + tmp.Count());


            string json_ = JsonSerializer.Serialize(tmp, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });
            return;

            var dtoList = new List<CustomDto>();

            foreach (custom tom in tmp)
            {
                var dto_ = new CustomDto
                {
                    startDate = tom.startdate,
                    endDate = tom.enddate,
                    stopdate = tom.stopdate,
                    m_date = tom.m_date,
                    ano = tom.ano,
                    cno = tom.cno,
                    cust = tom.cust,
                    name = tom.name,
                    address = tom.address ,
                    //Ips
                    ip1 = BuildIp(tom.ip11, tom.ip12, tom.ip13, tom.ip14),
                    ip2 = BuildIp(tom.ip21, tom.ip22, tom.ip23, tom.ip24),
                    ip3 = BuildIp(tom.ip31, tom.ip32, tom.ip33, tom.ip34),
                    ip4 = BuildIp(tom.ip41, tom.ip42, tom.ip43, tom.ip44),
                    ip5 = BuildIp(tom.ip51, tom.ip52, tom.ip53, tom.ip54),
                    ip6 = BuildIp(tom.ip61, tom.ip62, tom.ip63, tom.ip64),

                    // MACs
                    mac1 = BuildMac(tom.mac11, tom.mac12, tom.mac13, tom.mac14, tom.mac15, tom.mac16),
                    mac2 = BuildMac(tom.mac21, tom.mac22, tom.mac23, tom.mac24, tom.mac25, tom.mac26),
                    mac3 = BuildMac(tom.mac31, tom.mac32, tom.mac33, tom.mac34, tom.mac35, tom.mac36),
                    mac4 = BuildMac(tom.mac41, tom.mac42, tom.mac43, tom.mac44, tom.mac45, tom.mac46),
                    mac5 = BuildMac(tom.mac51, tom.mac52, tom.mac53, tom.mac54, tom.mac55, tom.mac56),
                    mac6 = BuildMac(tom.mac61, tom.mac62, tom.mac63, tom.mac64, tom.mac65, tom.mac66),

                };
                dtoList.Add(dto_);
            }
            if (!dtoList.Any())
            {
                messageRecord("沒有符合條件的資料，不發送。");
                return;
            }
            string url = "https://communitynet.renthouse.app/api/custom/receive";

            string json = JsonSerializer.Serialize(dtoList, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });
            //檢視更新資料
            lst_Target.Items.Add(json);
            tbx_APIJSON.Text = json;
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // 這裡建立 HttpClient 實例
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();
                lst_Target.Items.Add($"Status: {response.StatusCode} ,result: {result}");
                messageRecord($"Status: {response.StatusCode} ,result: {result}");
                lst_Target.Items.Add(response.StatusCode);
                lst_Target.Items.Add(result);

            }
        }
        private static string BuildIp(params decimal?[] parts)
        {
            return string.Join(".", parts.Select(p => p?.ToString() ?? "0"));
        }

        private static string BuildMac(params string[] parts)
        {
            return string.Join(":", parts.Select(p => string.IsNullOrWhiteSpace(p) ? "00" : p));
        }
        /// <summary>
        /// 測試連線
        /// </summary>
        public async void TestConnection()
        {
            bool _localDbConnected = TestLocal_Connection(sourceConnStr);
            bool _remoteApiConnected = await GetLastDatetime();

            messageRecord("_localDbConnected：" + _localDbConnected);
            messageRecord("_remoteApiConnected：" + _remoteApiConnected);

            if (_localDbConnected && _remoteApiConnected)
            {
                btn_Sync.Enabled = true;
                messageRecord("同步按鈕已啟用");
            }
        }
        public class CustomDto
        {
            public DateTime? startDate { get; set; }
            public DateTime? endDate { get; set; }
            public DateTime? m_date { get; set; }
            public DateTime? stopdate { get; set; }

      

            public string ano { get; set; }
            public string cno { get; set; }
            public string cust { get; set; }
            public string name { get; set; }
            public string address { get; set; }

            // IP
            public string ip1 { get; set; }
            public string ip2 { get; set; }
            public string ip3 { get; set; }
            public string ip4 { get; set; }
            public string ip5 { get; set; }
            public string ip6 { get; set; }

            // MAC
            public string mac1 { get; set; }
            public string mac2 { get; set; }
            public string mac3 { get; set; }
            public string mac4 { get; set; }
            public string mac5 { get; set; }
            public string mac6 { get; set; }
        }
        /// <summary>
        /// 選擇社區
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 選擇社區 顯示IP 清單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clb_communies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選擇項目後 如何顯示對應的 IP清單
            if (clb_communies.SelectedItem == null)
                return;

            // 取得目前選中的項目名稱
            string[] selectedCommunity = clb_communies.SelectedItem.ToString().Split(',');

            // 根據項目名稱查詢對應的 IP 清單（這裡示範用字典或資料表）
              List<string> ipList = GetIpListByCommunity(selectedCommunity[0]);


            if (ipList == null || ipList.Count == 0)
            {
                tbx_APIJSON.Text = $"社區：{selectedCommunity} 無對應 IP 清單";
                return;
            }

            // 顯示在 TextBox（每行一個 IP）
            tbx_APIJSON.Text = string.Join(Environment.NewLine, ipList);
        }

        // 模擬查詢 IP 清單的方法
        private List<string> GetIpListByCommunity(string community)
        {
            // 你可以改成實際查 DB 或呼叫
            community = community.Replace("[", "").Replace("]", "").Replace(" ", "");
            var PK = community.Split('_');
            var pkParts = community.Split('_');
            if (pkParts.Length != 2)
                return new List<string>(); // 格式不正確時避免例外

            string ano = pkParts[0];
            string cno = pkParts[1];
            //string cust = pkParts[2];

            var rawList = _db.custom
                .Where(x => x.use_kind == 1)
                .Where(x => x.ano == ano && x.cno == cno)
                .OrderBy(x => x.ano)
                .OrderBy(x => x.cno)
                .Select(x => new
                {
                    x.name, 
                    ip1 = x.ip11+ "."+ x.ip12 + "." + x.ip13 + "." + x.ip14 ,
                    x.setdate,
                    x.startdate ,
                    x.enddate,
                    x.stopdate ,
                    x.adate  ,
                    x.addn ,
                    x.pdate1 ,
                    x.pdate2 })
                .ToList();

            var tmp = rawList
           
                      .Select(x => new
                      {
                          姓名 = HideMiddle(x.name),
                          ip1 = x.ip1,
                          裝機日 = x.setdate,
                          起算日 = x.startdate,
                          到期日 = x.enddate,
                          退租日期 = x.stopdate,
                          暫開通日期 = x.adate,
                          暫開通日數 = x.addn,
                          暫停起始日 = x.pdate1,
                          暫停終止日 = x.pdate2
                      }).ToList();
            dgv_APIJSON.DataSource = tmp;
            return null;
        }
        private string HideMiddle(string name)
        {
            if (string.IsNullOrEmpty(name) )
                return name;
            else if( name.Length == 2)
            {
                return name[0] + "*"  ;
            }
            // 保留第一和最後一個字，中間以空白取代
            return name[0] + " * " + name[name.Length - 1];

        }

        /// <summary>
        /// 排序功能
        /// </summary>
        private void SortCheckedListBox()
                {
                    var checkedItems = new List<object>();
                    var uncheckedItems = new List<object>();
                    _isSorting = true;
                    foreach (var item in clb_communies.Items)
                    {
                        if (clb_communies.CheckedItems.Contains(item))
                            checkedItems.Add(item);
                        else
                            uncheckedItems.Add(item);
                    }

                    clb_communies.Items.Clear();

                    foreach (var item in checkedItems)
                    {
                        int idx = clb_communies.Items.Add(item);
                        clb_communies.SetItemChecked(idx, true);
                    }

                    foreach (var item in uncheckedItems.OrderBy(x => x.ToString()))
                    {
                        clb_communies.Items.Add(item);
                    }
                    _isSorting = false;
                }
        /// <summary>
        /// 勾選項目變化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clb_communies_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_isSorting) return; // 正在排序時跳過

            this.BeginInvoke((MethodInvoker)delegate {
                SortCheckedListBox();
            });

            try
            {
                foreach (KeyValuePair<string, string> kv in clb_communies.CheckedItems)
                {
                    // MessageBox.Show($"勾選：{kv.Value}, ID={kv.Key}");
                }
                // 用 BeginInvoke 延後執行，等勾選狀態真的更新完
                this.BeginInvoke((MethodInvoker)delegate {
                    SortCheckedListBox();
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show($"error" + ex);
            }
        }

        private void dgv_APIJSON_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgv_APIJSON.Columns[e.ColumnIndex].DataPropertyName;
            if (string.IsNullOrEmpty(columnName))
                return;

            // 如果點同一欄，切換排序方向
            if (lastSortedColumn == columnName)
                sortAscending = !sortAscending;
            else
                sortAscending = true;

            lastSortedColumn = columnName;

            // 取目前資料來源
            var list = dgv_APIJSON.DataSource as IEnumerable<dynamic>;
            if (list == null) return;

            // 使用 LINQ 重新排序
            var sorted = sortAscending
                ? list.OrderBy(x => GetPropertyValue(x, columnName)).ToList()
                : list.OrderByDescending(x => GetPropertyValue(x, columnName)).ToList();

            dgv_APIJSON.DataSource = sorted;
        }
        // 小工具：用反射取屬性值
        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName)?.GetValue(obj, null);
        }
    }
}
