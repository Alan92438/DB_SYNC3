using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
    [Table("custom")]
    public partial class custom
    {
        /// <summary>
        /// PK
        /// </summary>
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] // ⬅ 自動遞增
        //public int customId { get; set; } // ✅ 新主鍵欄位
        /// <summary>
        /// 所屬社區編號
        /// </summary>
        //public int BelongToCommId { get; set; }
        /// <summary>
        /// 區域碼
        /// </summary>
        public string ano { get; set; }

        /// <summary>
        /// 社區編號 非唯一值
        /// </summary>
        public string cno { get; set; }

        /// <summary>
        /// 類別
        /// </summary>
        public string cust_type { get; set; }

        /// <summary>
        /// 客戶編號 非唯一值
        /// </summary>
        public string cust { get; set; }

        /// <summary>
        /// 客戶名稱
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 裝機地郵遞區號
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        /// 裝機地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 棟別
        /// </summary>
        public string build_no { get; set; }

        /// <summary>
        /// 戶籍郵遞區號
        /// </summary>
        public string zip1 { get; set; }

        /// <summary>
        /// 戶籍地址
        /// </summary>
        public string address1 { get; set; }

        /// <summary>
        /// 帳單寄送地
        /// </summary>
        public decimal? sendto { get; set; }

        /// <summary>
        /// 電話區碼
        /// </summary>
        public string area { get; set; }

        /// <summary>
        /// 電話
        /// </summary>
        public string tel { get; set; }

        /// <summary>
        /// 分機
        /// </summary>
        public string ext { get; set; }

        /// <summary>
        /// 手機
        /// </summary>
        public string cell { get; set; }

        /// <summary>
        /// 手機2
        /// </summary>
        public string cell2 { get; set; }

        /// <summary>
        /// 身分證號
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// e晶片位址選項
        /// </summary>
        public decimal? se_no { get; set; }

        public decimal? ip11 { get; set; }

        public decimal? ip12 { get; set; }

        public decimal? ip13 { get; set; }

        public decimal? ip14 { get; set; }

        /// <summary>
        /// 網段
        /// </summary>
        public decimal? ip14_sub { get; set; }

        public string mac11 { get; set; }

        public string mac12 { get; set; }

        public string mac13 { get; set; }

        public string mac14 { get; set; }

        public string mac15 { get; set; }

        public string mac16 { get; set; }

        public decimal? ip21 { get; set; }

        public decimal? ip22 { get; set; }

        public decimal? ip23 { get; set; }

        public decimal? ip24 { get; set; }

        /// <summary>
        /// 網段
        /// </summary>
        public decimal? ip24_sub { get; set; }

        public string mac21 { get; set; }

        public string mac22 { get; set; }

        public string mac23 { get; set; }

        public string mac24 { get; set; }

        public string mac25 { get; set; }

        public string mac26 { get; set; }

        public decimal? ip31 { get; set; }

        public decimal? ip32 { get; set; }

        public decimal? ip33 { get; set; }

        public decimal? ip34 { get; set; }

        /// <summary>
        /// 網段
        /// </summary>
        public decimal? ip34_sub { get; set; }

        public string mac31 { get; set; }

        public string mac32 { get; set; }

        public string mac33 { get; set; }

        public string mac34 { get; set; }

        public string mac35 { get; set; }

        public string mac36 { get; set; }

        public decimal? ip41 { get; set; }

        public decimal? ip42 { get; set; }

        public decimal? ip43 { get; set; }

        public decimal? ip44 { get; set; }

        public decimal? ip44_sub { get; set; }

        public string mac41 { get; set; }

        public string mac42 { get; set; }

        public string mac43 { get; set; }

        public string mac44 { get; set; }

        public string mac45 { get; set; }

        public string mac46 { get; set; }

        public decimal? ip51 { get; set; }

        public decimal? ip52 { get; set; }

        public decimal? ip53 { get; set; }

        public decimal? ip54 { get; set; }

        public decimal? ip54_sub { get; set; }

        public string mac51 { get; set; }

        public string mac52 { get; set; }

        public string mac53 { get; set; }

        public string mac54 { get; set; }

        public string mac55 { get; set; }

        public string mac56 { get; set; }

        public decimal? ip61 { get; set; }

        public decimal? ip62 { get; set; }

        public decimal? ip63 { get; set; }

        public decimal? ip64 { get; set; }

        public decimal? ip64_sub { get; set; }

        public string mac61 { get; set; }

        public string mac62 { get; set; }

        public string mac63 { get; set; }

        public string mac64 { get; set; }

        public string mac65 { get; set; }

        public string mac66 { get; set; }

        /// <summary>
        /// 裝機日
        /// </summary>
        public DateTime? setdate { get; set; }

        /// <summary>
        /// 起算日
        /// </summary>
        public DateTime? startdate { get; set; }

        /// <summary>
        /// 到期日
        /// </summary>
        public DateTime? enddate { get; set; }

        /// <summary>
        /// 退租日期
        /// </summary>
        public DateTime? stopdate { get; set; }

        /// <summary>
        /// 暫開通
        /// </summary>
        public bool? add7 { get; set; }

        /// <summary>
        /// 暫開通日期
        /// </summary>
        public DateTime? adate { get; set; }

        /// <summary>
        /// 暫開通日數
        /// </summary>
        public decimal? addn { get; set; }

        /// <summary>
        /// 暫停期間
        /// </summary>
        public bool? pause { get; set; }

        /// <summary>
        /// 暫停起始日
        /// </summary>
        public DateTime? pdate1 { get; set; }

        /// <summary>
        /// 暫停終止日
        /// </summary>
        public DateTime? pdate2 { get; set; }

        /// <summary>
        /// 合約代號
        /// </summary>
        public string con_no { get; set; }

        /// <summary>
        /// 設定費
        /// </summary>
        public decimal? set_price { get; set; }

        /// <summary>
        /// 施工費
        /// </summary>
        public decimal? work_price { get; set; }

        /// <summary>
        /// 押金
        /// </summary>
        public decimal? rent_price { get; set; }

        /// <summary>
        /// 設備租金
        /// </summary>
        public decimal? rent_pay { get; set; }

        /// <summary>
        /// 借用設備
        /// </summary>
        public string rent_fac { get; set; }

        /// <summary>
        /// 使用狀態（1-使用中 2-欠款斷線 3-退租斷線 4-租約未到期自停 5-申裝中 6.已斷線 7.暫停）
        /// </summary>
        public decimal? use_kind { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        public string memo { get; set; }

        public string t_control1 { get; set; }

        public string t_control2 { get; set; }

        public string t_control3 { get; set; }

        public string t_control4 { get; set; }

        public string t_control5 { get; set; }

        public string t_control6 { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? m_date { get; set; }

        /// <summary>
        /// 修改人員
        /// </summary>
        public string m_meno { get; set; }
    }
 