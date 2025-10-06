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
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace DB_SYNC3
{
    public partial class Form1 : Form
    {
        string sourceConnStr = "Server=localhost\\SQLEXPRESS;Database=CMS;User Id=sa;Password=Magical9070;";
        private MyDbContext _db;
        private DateTime? _lastDate;
        public Form1()
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
                conn.Open();

                // 取得資料表清單
                DataTable DB = conn.GetSchema("Tables");
                // custom 在最上方
                var customTables = DB.Rows.Cast<DataRow>()
                    .Where(r => r["TABLE_NAME"].ToString().Equals("custom", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (customTables.Any())
                {
                    lstTables.Items.Add("--更新資料表--");
                    foreach (var row in customTables)
                    {
                        string schema = row["TABLE_SCHEMA"].ToString();
                        string tableName = row["TABLE_NAME"].ToString();
                        lstTables.Items.Add($"{schema}.{tableName}");
                    }
                }

                // 其他資料表
                var otherTables = DB.Rows.Cast<DataRow>()
                    .Where(r => !r["TABLE_NAME"].ToString().Equals("custom", StringComparison.OrdinalIgnoreCase))
                    .OrderBy(r => r["TABLE_NAME"].ToString()) // 排序比較美觀
                    .ToList();

                if (otherTables.Any())
                {
                    lstTables.Items.Add("--其他資料表--");
                    foreach (var row in otherTables)
                    {
                        string schema = row["TABLE_SCHEMA"].ToString();
                        string tableName = row["TABLE_NAME"].ToString();
                        lstTables.Items.Add($"{schema}.{tableName}");
                    }
                }


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

            // 4️⃣ JSON 序列化設定
            messageRecord("--ST JSON 序列化設定--");
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
            var json = JsonSerializer.Serialize(payload, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // 5️⃣ 發送 POST
            messageRecord("--ST 建立 HttpClient 並發送 POST--");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.PostAsync("https://communitynet.renthouse.app/api/syncdata", content);

                    // 6️⃣ 回應檢查
                    messageRecord("--ST 回應檢查--");
                    if (response.IsSuccessStatusCode)
                    {
                        messageRecord("✅ 多資料表資料已成功送出");
                    }
                    else
                    {
                        var error = await response.Content.ReadAsStringAsync();
                        messageRecord($"❌ 發送失敗: {response.StatusCode} / {error}");
                    }
                }
            }
            catch (Exception ex)
            {
                messageRecord("❌ 發送 POST 失敗：" + ex.Message);
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


    }
}
