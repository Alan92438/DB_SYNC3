using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("memb")]
/// <summary>
/// 員工主檔
/// </summary>
public partial class memb
{
    /// <summary>
    /// 員工編號
    /// </summary>
    [Key]
    public string meno { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// 卡號
    /// </summary>
    public string card_no { get; set; }

    /// <summary>
    /// 生日
    /// </summary>
    public DateTime birthday { get; set; }

    /// <summary>
    /// 性別
    /// </summary>
    public decimal? sex { get; set; }

    /// <summary>
    /// 身份証字號
    /// </summary>
    public string idno { get; set; }

    /// <summary>
    /// 出生地
    /// </summary>
    public string birplace { get; set; }

    /// <summary>
    /// 外國人
    /// </summary>
    public bool? foreignet { get; set; }

    /// <summary>
    /// 婚別
    /// </summary>
    public bool? marry { get; set; }

    /// <summary>
    /// 戶籍地址
    /// </summary>
    public string adr1 { get; set; }

    /// <summary>
    /// 戶籍電話
    /// </summary>
    public string tel1 { get; set; }

    /// <summary>
    /// 通訊地址
    /// </summary>
    public string adr2 { get; set; }

    /// <summary>
    /// 通訊電話
    /// </summary>
    public string tel2 { get; set; }

    /// <summary>
    /// 部門
    /// </summary>
    public string dpna { get; set; }

    /// <summary>
    /// 職位
    /// </summary>
    public string ra { get; set; }

    /// <summary>
    /// 職務
    /// </summary>
    public string rank { get; set; }

    /// <summary>
    /// 階
    /// </summary>
    public decimal? tit { get; set; }

    /// <summary>
    /// 級
    /// </summary>
    public decimal? title { get; set; }

    /// <summary>
    /// 到職日期
    /// </summary>
    public DateTime? arrdate { get; set; }

    /// <summary>
    /// 離職日期
    /// </summary>
    public DateTime? quidate { get; set; }

    /// <summary>
    /// 特殊日給額
    /// </summary>
    public decimal? dpay { get; set; }

    /// <summary>
    /// 學歷
    /// </summary>
    public string school { get; set; }

    /// <summary>
    /// 學歷
    /// </summary>
    public decimal? school1 { get; set; }

    /// <summary>
    /// 加保日期
    /// </summary>
    public DateTime? insdate { get; set; }

    /// <summary>
    /// 扣勞保費
    /// </summary>
    public decimal? inspric_1 { get; set; }

    /// <summary>
    /// 扣健保費
    /// </summary>
    public decimal? inspric_2 { get; set; }

    /// <summary>
    /// 勞保加保金額
    /// </summary>
    public decimal? inspric1 { get; set; }

    /// <summary>
    /// 健保加保金額
    /// </summary>
    public decimal? inspric2 { get; set; }

    /// <summary>
    /// 加保眷屬
    /// </summary>
    public decimal? inspepo { get; set; }

    /// <summary>
    /// 護照號碼
    /// </summary>
    public string passport { get; set; }

    /// <summary>
    /// 護照到期日
    /// </summary>
    public DateTime? p_date { get; set; }

    /// <summary>
    /// 台胞証號碼
    /// </summary>
    public string taiwan { get; set; }

    /// <summary>
    /// 台胞証到期日
    /// </summary>
    public DateTime? t_date { get; set; }

    /// <summary>
    /// 存簿帳號
    /// </summary>
    public string bankno { get; set; }

    /// <summary>
    /// 年供俸
    /// </summary>
    public decimal? yearpay { get; set; }

    /// <summary>
    /// 現場津貼
    /// </summary>
    public bool? hardpay { get; set; }

    /// <summary>
    /// 直接人員
    /// </summary>
    public bool? hardmemb { get; set; }

    /// <summary>
    /// 契約工
    /// </summary>
    public decimal? hardmemb1 { get; set; }

    /// <summary>
    /// 建教生
    /// </summary>
    public decimal? hardschool { get; set; }

    /// <summary>
    /// 其他津貼
    /// </summary>
    public decimal? extpay { get; set; }

    /// <summary>
    /// 工會會員
    /// </summary>
    public bool? union_ { get; set; }

    /// <summary>
    /// 所得稅
    /// </summary>
    public decimal? r1 { get; set; }

    /// <summary>
    /// 伙食費
    /// </summary>
    public decimal? r5 { get; set; }

    /// <summary>
    /// 貸款
    /// </summary>
    public decimal? r6 { get; set; }

    /// <summary>
    /// 勞退月提繳工資
    /// </summary>
    public decimal? ss { get; set; }

    /// <summary>
    /// 勞退金公司提撥
    /// </summary>
    public decimal? s1 { get; set; }

    /// <summary>
    /// 勞退金個人提撥
    /// </summary>
    public decimal? s2 { get; set; }

    /// <summary>
    /// 日/月 薪
    /// </summary>
    public decimal? dm { get; set; }

    /// <summary>
    /// 是否打卡
    /// </summary>
    public bool? card { get; set; }

    /// <summary>
    /// 履歷
    /// </summary>
    public string plist { get; set; }

    /// <summary>
    /// 照片
    /// </summary>
    public byte[] photo { get; set; }

    public bool? other { get; set; }

    /// <summary>
    /// 預設班別
    /// </summary>
    public string class_no { get; set; }

    /// <summary>
    /// 密碼
    /// </summary>
    public string p { get; set; }

    /// <summary>
    /// 更改日期
    /// </summary>
    public DateTime? m_date { get; set; }

    /// <summary>
    /// 更改人員
    /// </summary>
    public string m_meno { get; set; }

    public byte[] timestamp_column { get; set; }
}
