using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class FeatureLargeCardManager : IFeatureLargeCardService
    {
        IFeatureLargeCardDal _featureLargeCardDal;

        public FeatureLargeCardManager(IFeatureLargeCardDal featureLargeCardDal)
        {
            _featureLargeCardDal = featureLargeCardDal;
        }

        public void TAdd(FeatureLargeCard t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(FeatureLargeCard t)
        {
            throw new NotImplementedException();
        }

        public FeatureLargeCard TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<FeatureLargeCard> TGetList()
        {
            return _featureLargeCardDal.GetList();
        }

        public void TUpdate(FeatureLargeCard t)
        {
            throw new NotImplementedException();
        }
    }
}
