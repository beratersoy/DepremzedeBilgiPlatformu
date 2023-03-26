using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class GuestInfo
    {
        [Key]
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PersonCount { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string RecordControl { get; set; }
        public string Stay { get; set; }
        public string Education { get; set; }
        public string Phsicology { get; set; }
        public string Employment { get; set; }
        public string Job { get; set; }
        public string License { get; set; }
        public string Launguage { get; set; }
        public string Disabled { get; set; }
        public string WorkingStatus { get; set; }
        public string AlternativePhone { get; set; }

        public int HomeInfoId { get; set; }
        public HomeInfo HomeInfo { get; set; }

        public List<NeedInfo> NeedInfos { get; set; }



    }
}
