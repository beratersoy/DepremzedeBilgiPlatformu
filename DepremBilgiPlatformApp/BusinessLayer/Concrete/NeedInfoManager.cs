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
    public class NeedInfoManager : INeedInfoServices

    {
        INeedInfo needInfoDal;


        public NeedInfoManager(INeedInfo needInfo)
        {
            this.needInfoDal = needInfo;
        }

        public NeedInfo GetNeedInfo(int id)
        {
            return needInfoDal.GetById(id);
        }

        public List<NeedInfo> GetList()
        {
            return needInfoDal.GetAllList();
        }

        public void NeedInfoAdd(NeedInfo _needInfo)
        {
            needInfoDal.Add(_needInfo);
        }

        public void NeedInfoRemove(NeedInfo _needInfo)
        {
            needInfoDal.Remove(_needInfo);
        }

        public void NeedInfoUpdate(NeedInfo _needInfo)
        {
            needInfoDal.Update(_needInfo);
        }
    }
}
