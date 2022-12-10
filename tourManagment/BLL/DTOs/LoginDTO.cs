using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class LoginDTO
    {
        public int id { get; set; }
        public int hostid { get; set; }
        public string loginaccess { get; set; }
        public System.DateTime Createdate { get; set; }
        public Nullable<System.DateTime> Expiredate { get; set; }
    }
}
