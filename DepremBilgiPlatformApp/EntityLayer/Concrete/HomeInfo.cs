using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HomeInfo
    {
        [Key]
        public int HomeInfoId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GuestCount { get; set; }
        public string Adress { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public string Detaction { get; set; }
        public string Deliver { get; set; }
             
        public List<GuestInfo> GuestInfos { get; set; }
    }
}
