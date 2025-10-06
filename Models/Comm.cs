namespace DB_SYNC3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("comm")]
    public partial class comm
    {
        [StringLength(2)]
        public string ano { get; set; }

        [StringLength(3)]
        public string cno { get; set; }

        [StringLength(5)]
        public string con_no { get; set; }

        [StringLength(20)]
        public string cname { get; set; }

        [StringLength(5)]
        public string zip { get; set; }

        [StringLength(40)]
        public string address { get; set; }

        [StringLength(3)]
        public string area { get; set; }

        [StringLength(8)]
        public string tel { get; set; }

        [StringLength(10)]
        public string chairperson { get; set; }

        [StringLength(10)]
        public string manager { get; set; }

        [StringLength(10)]
        public string cell { get; set; }

        [StringLength(8)]
        public string hotline { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? uip011 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? uip012 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? uip013 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? uip014 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? uip021 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? uip022 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? uip023 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? uip024 { get; set; }

        [StringLength(5)]
        public string up01 { get; set; }

        [StringLength(5)]
        public string down01 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip011 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip012 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip013 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip014 { get; set; }

        [StringLength(3)]
        public string area01 { get; set; }

        [StringLength(8)]
        public string tel01 { get; set; }

        [StringLength(5)]
        public string up02 { get; set; }

        [StringLength(5)]
        public string down02 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip021 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip022 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip023 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip024 { get; set; }

        [StringLength(3)]
        public string area02 { get; set; }

        [StringLength(8)]
        public string tel02 { get; set; }

        [StringLength(5)]
        public string up03 { get; set; }

        [StringLength(5)]
        public string down03 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip031 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip032 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip033 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip034 { get; set; }

        [StringLength(3)]
        public string area03 { get; set; }

        [StringLength(8)]
        public string tel03 { get; set; }

        [StringLength(5)]
        public string up04 { get; set; }

        [StringLength(5)]
        public string down04 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip041 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip042 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip043 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip044 { get; set; }

        [StringLength(3)]
        public string area04 { get; set; }

        [StringLength(8)]
        public string tel04 { get; set; }

        [StringLength(5)]
        public string up05 { get; set; }

        [StringLength(5)]
        public string down05 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip051 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip052 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip053 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip054 { get; set; }

        [StringLength(3)]
        public string area05 { get; set; }

        [StringLength(8)]
        public string tel05 { get; set; }

        [StringLength(5)]
        public string up06 { get; set; }

        [StringLength(5)]
        public string down06 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip061 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip062 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip063 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip064 { get; set; }

        [StringLength(3)]
        public string area06 { get; set; }

        [StringLength(8)]
        public string tel06 { get; set; }

        [StringLength(5)]
        public string up07 { get; set; }

        [StringLength(5)]
        public string down07 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip071 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip072 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip073 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip074 { get; set; }

        [StringLength(3)]
        public string area07 { get; set; }

        [StringLength(8)]
        public string tel07 { get; set; }

        [StringLength(5)]
        public string up08 { get; set; }

        [StringLength(5)]
        public string down08 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip081 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip082 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip083 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip084 { get; set; }

        [StringLength(3)]
        public string area08 { get; set; }

        [StringLength(8)]
        public string tel08 { get; set; }

        [StringLength(5)]
        public string up09 { get; set; }

        [StringLength(5)]
        public string down09 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip091 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip092 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip093 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip094 { get; set; }

        [StringLength(3)]
        public string area09 { get; set; }

        [StringLength(8)]
        public string tel09 { get; set; }

        [StringLength(5)]
        public string up10 { get; set; }

        [StringLength(5)]
        public string down10 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip101 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip102 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip103 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip104 { get; set; }

        [StringLength(3)]
        public string area10 { get; set; }

        [StringLength(8)]
        public string tel10 { get; set; }

        [StringLength(5)]
        public string up11 { get; set; }

        [StringLength(5)]
        public string down11 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip111 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip112 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip113 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip114 { get; set; }

        [StringLength(3)]
        public string area11 { get; set; }

        [StringLength(8)]
        public string tel11 { get; set; }

        [StringLength(5)]
        public string up12 { get; set; }

        [StringLength(5)]
        public string down12 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip121 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip122 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip123 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip124 { get; set; }

        [StringLength(3)]
        public string area12 { get; set; }

        [StringLength(8)]
        public string tel12 { get; set; }

        [StringLength(5)]
        public string up13 { get; set; }

        [StringLength(5)]
        public string down13 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip131 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip132 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip133 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip134 { get; set; }

        [StringLength(3)]
        public string area13 { get; set; }

        [StringLength(8)]
        public string tel13 { get; set; }

        [StringLength(5)]
        public string up14 { get; set; }

        [StringLength(5)]
        public string down14 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip141 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip142 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip143 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip144 { get; set; }

        [StringLength(3)]
        public string area14 { get; set; }

        [StringLength(8)]
        public string tel14 { get; set; }

        [StringLength(5)]
        public string up15 { get; set; }

        [StringLength(5)]
        public string down15 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip151 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip152 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip153 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip154 { get; set; }

        [StringLength(3)]
        public string area15 { get; set; }

        [StringLength(8)]
        public string tel15 { get; set; }

        [StringLength(5)]
        public string up16 { get; set; }

        [StringLength(5)]
        public string down16 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip161 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip162 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip163 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ip164 { get; set; }

        [StringLength(3)]
        public string area16 { get; set; }

        [StringLength(8)]
        public string tel16 { get; set; }

        [StringLength(15)]
        public string dns1 { get; set; }

        [StringLength(15)]
        public string dns2 { get; set; }

        [StringLength(15)]
        public string gateway { get; set; }

        [StringLength(15)]
        public string mask { get; set; }

        [StringLength(4)]
        public string meno { get; set; }

        [StringLength(4)]
        public string vendor { get; set; }

        [Column(TypeName = "text")]
        public string memo { get; set; }

        [StringLength(20)]
        public string memo1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? in_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? co_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? co_kind { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? co_price { get; set; }

        public bool? ethernet { get; set; }

        public bool? adsl { get; set; }

        public bool? vdsl { get; set; }

        public bool? hpna { get; set; }

        public bool? other { get; set; }

        [StringLength(20)]
        public string machine1 { get; set; }

        [StringLength(20)]
        public string machine2 { get; set; }

        [StringLength(40)]
        public string web1 { get; set; }

        [StringLength(40)]
        public string web2 { get; set; }

        [StringLength(40)]
        public string web3 { get; set; }

        [StringLength(40)]
        public string web4 { get; set; }

        [StringLength(40)]
        public string web5 { get; set; }

        [StringLength(15)]
        public string web1ex { get; set; }

        [StringLength(15)]
        public string web2ex { get; set; }

        [StringLength(15)]
        public string web3ex { get; set; }

        [StringLength(15)]
        public string web4ex { get; set; }

        [StringLength(15)]
        public string web5ex { get; set; }

        public bool? special { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? electric { get; set; }

        [StringLength(10)]
        public string cco_no { get; set; }

        public bool? e_act { get; set; }

        [StringLength(10)]
        public string e_username { get; set; }

        [StringLength(20)]
        public string e_password { get; set; }

        public DateTime? m_date { get; set; }

        [StringLength(4)]
        public string m_meno { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp_column { get; set; }

        /// <summary>
        /// ªÀ°ÏID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommId { get; set; }

        public int CommunityHostId { get; set; }
    }
}
