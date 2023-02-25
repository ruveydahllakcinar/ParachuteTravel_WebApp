using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IGenericUnitOfWorkDal<T> where T : class
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TMultiUpdate(List<T> t);
        T TGetById(int id);
    }
}
