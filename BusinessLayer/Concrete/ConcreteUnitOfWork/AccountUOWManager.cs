using BusinessLayer.Abstract.AbstractUnitOfWork;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ConcreteUnitOfWork
{
    public class AccountUOWManager : IAccountUOWService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUnitOfWorkDal _uowDal;

        public AccountUOWManager(IAccountDal accountDal, IUnitOfWorkDal uowDal)
        {
            _accountDal = accountDal;
            _uowDal = uowDal;
        }

        public Account TGetById(int id)
        {
            return _accountDal.TGetById(id);
        }

        public void TInsert(Account t)
        {
            _accountDal.TInsert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.TMultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDal.TUpdate(t);
            _uowDal.Save();
        }

        
    }
}