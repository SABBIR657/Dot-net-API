using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminModel
    {
        public int hostid { get; set; }
        public string username { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string mobilenumber { get; set; }
        public string password { get; set; }
    }
}
