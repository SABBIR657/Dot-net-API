using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HotelModel
    {
        public int hotelid { get; set; }
        public string hoteltype { get; set; }
        public string hotellocation { get; set; }
        public string hotelprice { get; set; }
    }
}
