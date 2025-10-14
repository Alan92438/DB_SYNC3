using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_SYNC.Models.DTO
{
    internal class CommunityItem
    {
        public string Code { get; set; }   // 代碼
        public string Name { get; set; }   // 顯示名稱
        public bool Checked { get; set; }  // 勾選狀態

        public override string ToString() => Name;
    }
}
