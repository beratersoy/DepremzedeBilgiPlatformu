using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NeedInfo
    {
        [Key]
        public int NeedInfoId { get; set; }
        public string Food { get; set; }
        public string LcwCard { get; set; }
        public string Bed { get; set; }
        public string Duvet { get; set; }
        public string Blanket { get; set; }
        public string Pillow { get; set; }
        public string Fuel { get; set; }
        public double Cash { get; set; }
        public string Hygiene { get; set; }
        public string Description { get; set; }
        public int GuestId { get; set; }
        public List<GuestInfo> GuestInfo { get; set; }
    }
}
