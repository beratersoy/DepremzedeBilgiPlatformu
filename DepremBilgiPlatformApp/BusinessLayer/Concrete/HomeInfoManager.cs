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
    public class HomeInfoManager : IHomeInfoServices
    {
        IHomeInfoDal _homeDal;


        public HomeInfoManager(IHomeInfoDal homeDal)
        {
            _homeDal = homeDal;
        }

        public HomeInfo GetHomeInfo(int id)
        {
            return _homeDal.GetById(id);
        }


        public List<HomeInfo> GetList()
        {
            return _homeDal.GetAllList();
        }

        public void HomeInfoAdd(HomeInfo _homeInfo)
        {
            _homeDal.Add(_homeInfo);
        }

        public void HomeInfoRemove(HomeInfo _homeInfo)
        {
            _homeDal.Remove(_homeInfo);
        }

        public void HomeInfoUpdate(HomeInfo _homeInfo)
        {
            _homeDal.Update(_homeInfo);
        }

       
    }
}
