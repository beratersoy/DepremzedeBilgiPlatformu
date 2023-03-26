using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGuestInfoServices
    {
        void GuestInfoAdd(GuestInfo guestInfo);
        void GuestInfoRemove(GuestInfo guestInfo);
        void GuestInfoUpdate(GuestInfo guestInfo);
        List<GuestInfo> GetList();
        GuestInfo GetGuestInfo(int id);


    }
}
