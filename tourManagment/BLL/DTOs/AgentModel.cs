using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AgentModel
    {
        public int agentid { get; set; }
        public string agentmail { get; set; }
        public string password { get; set; }
        public string agentname { get; set; }
        public string agentcontact { get; set; }
        public string username { get; set; }
    }
}
