using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_SYNC3.Models.DTO
{
    internal class SyncDataDto
    {
        public List<custom> CustomList { get; set; }

        public List<comm> comm { get; set; }

        public List<maintain> maintain { get; set; } 
    }
}
