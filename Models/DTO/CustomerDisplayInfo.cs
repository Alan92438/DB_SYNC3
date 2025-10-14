using System;

namespace DB_SYNC3
{
    internal class CustomerDisplayInfo
    {
        public string 會員編號 { get; set; }

        public string 姓名 { get; set; }
        public string ip1 { get; set; }
        public DateTime? 裝機日 { get; set; }
        public DateTime? 起算日 { get; set; }
        public DateTime? 到期日 { get; set; }
        public DateTime? 退租日期 { get; set; }
        public DateTime? 暫開通日期 { get; set; }
        public decimal? 暫開通日數 { get; set; }
        public DateTime? 暫停起始日 { get; set; }
        public DateTime? 暫停終止日 { get; set; }
    }
}