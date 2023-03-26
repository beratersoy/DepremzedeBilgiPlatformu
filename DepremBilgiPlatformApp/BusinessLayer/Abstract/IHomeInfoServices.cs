using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHomeInfoServices
    {
        void HomeInfoAdd(HomeInfo _homeInfo);
        void HomeInfoRemove(HomeInfo _homeInfo);
        void HomeInfoUpdate(HomeInfo _homeInfo);
        List<HomeInfo> GetList();
        HomeInfo GetHomeInfo(int id);
    }
}
