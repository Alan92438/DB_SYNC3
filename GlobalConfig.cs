using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_SYNC3
{
    public class GlobalConfig
    {
        public static string ConnectionString { get; } =
                ConfigurationManager.ConnectionStrings["CMS"].ConnectionString;
        /// <summary>
        /// 目前登入者
        /// </summary>
        public static memb CurrentUser { get; set; } 
    }
}
