using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("maintain")]
/// <summary>
/// 維修派工
/// </summary>
public partial class maintain
{
    /// <summary>
    /// 修改時間
    /// </summary>
    [Key, Column(Order = 0)]
    public DateTime? m_date { get; set; }
    /// <summary>
    /// 維修單號
    /// </summary>
    public string ticket { get; set; }

    /// <summary>
    /// 區域編號
    /// </summary>
    public string ano { get; set; }

    /// <summary>
    /// 社區編號
    /// </summary>
    public string cno { get; set; }

    /// <summary>
    /// 客戶編號
    /// </summary>
    public string cust { get; set; }

    /// <summary>
    /// 客戶名稱
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// 電話區域碼
    /// </summary>
    public string area { get; set; }

    /// <summary>
    /// 電話
    /// </summary>
    public string tel { get; set; }

    /// <summary>
    /// 分機號碼
    /// </summary>
    public string ext { get; set; }

    /// <summary>
    /// 手機
    /// </summary>
    public string cell { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string address { get; set; }

    /// <summary>
    /// 社區名稱
    /// </summary>
    public string cname { get; set; }

    /// <summary>
    /// 來電時間
    /// </summary>
    public DateTime? intime { get; set; }

    /// <summary>
    /// 回電時間
    /// </summary>
    public DateTime? outtime { get; set; }

    /// <summary>
    /// 到府時間
    /// </summary>
    public DateTime? gotime { get; set; }

    /// <summary>
    /// 離開時間
    /// </summary>
    public DateTime? backtime { get; set; }

    /// <summary>
    /// 完成時間
    /// </summary>
    public DateTime? finishtime { get; set; }

    /// <summary>
    /// 是否使用分享器
    /// </summary>
    public bool? hub { get; set; }

    /// <summary>
    /// 作業系統
    /// </summary>
    public decimal? os { get; set; }

    /// <summary>
    /// 故障問題
    /// </summary>
    public string probrem { get; set; }

    /// <summary>
    /// 處理狀況
    /// </summary>
    public string solution { get; set; }

    /// <summary>
    /// 登錄人員
    /// </summary>
    public string meno1 { get; set; }

    /// <summary>
    /// 處理人員
    /// </summary>
    public string meno2 { get; set; }

    /// <summary>
    /// 組別
    /// </summary>
    public decimal? gno { get; set; }

    /// <summary>
    /// 處理狀況（1-很差 2-尚可 3-優良）
    /// </summary>
    public decimal? service { get; set; }

    /// <summary>
    /// 處理方式（1-電話聯絡 2-用戶端 3-系統端）
    /// </summary>
    public decimal? serviceby { get; set; }

    /// <summary>
    /// 客戶建議
    /// </summary>
    public string suggest { get; set; }

    /// <summary>
    /// 事由（1-裝機 2-檢測 3-拆機 4-復機 5-來電紀錄）
    /// </summary>
    public decimal? kind { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string memo { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    //public DateTime? m_date { get; set; }

    /// <summary>
    /// 修改人員
    /// </summary>
    public string m_meno { get; set; }
}
