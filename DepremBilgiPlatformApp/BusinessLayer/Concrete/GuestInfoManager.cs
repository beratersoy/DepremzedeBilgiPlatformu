using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuestInfoManager : IGuestInfoServices
    {
        IGuestInfoDal _GuestInfoDal;

        public GuestInfoManager(IGuestInfoDal GuestInfoDal)
        {
            _GuestInfoDal = GuestInfoDal;
        }
        public GuestInfo GetGuestInfo(int id)
        {
            return _GuestInfoDal.GetById(id);
        }

        public List<GuestInfo> GetList()
        {
            return _GuestInfoDal.GetAllList();
        }

        public void GuestInfoAdd(GuestInfo guestInfo)
        {
            _GuestInfoDal.Add(guestInfo);
        }

        public void GuestInfoRemove(GuestInfo guestInfo)
        {
            _GuestInfoDal.Remove(guestInfo);
        }

        public void GuestInfoUpdate(GuestInfo guestInfo)
        {
            _GuestInfoDal.Update(guestInfo);
        }
    }
}

