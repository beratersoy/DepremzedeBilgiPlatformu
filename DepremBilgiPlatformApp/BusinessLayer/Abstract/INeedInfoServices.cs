using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INeedInfoServices
    {
        void NeedInfoAdd(NeedInfo _needInfo);
        void NeedInfoRemove(NeedInfo _needInfo);
        void NeedInfoUpdate(NeedInfo _needInfo);
        List<NeedInfo> GetList();
        NeedInfo GetNeedInfo(int id);
    }
}
