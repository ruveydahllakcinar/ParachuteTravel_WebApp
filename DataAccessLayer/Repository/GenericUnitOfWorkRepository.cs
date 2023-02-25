using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericUnitOfWorkRepository<T> : IGenericUnitOfWorkDal<T> where T : class
    {
        private readonly Context _context;

        public GenericUnitOfWorkRepository(Context context)
        {
            _context = context;
        }
        public T TGetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void TInsert(T t)
        {
            _context.Add(t);
        }

        public void TMultiUpdate(List<T> t)
        {
            _context.UpdateRange(t);
        }

        public void TUpdate(T t)
        {
            _context.Update(t);
        }
    }
}
