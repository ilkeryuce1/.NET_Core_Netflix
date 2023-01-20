using BusinnessLayer.Abstract;
using DataAceesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.Data.Edm.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class AccountManager : IAccountService
    {
        IAccountDal _AccountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _AccountDal = accountDal;
        }

        public void Add(Account t)
        {
            _AccountDal.Insert(t);
        }

        public List<Account> GetAllList()
        {
            return _AccountDal.GetListAll();
        }

        public Account GetById(int id)
        {
            return _AccountDal.GetByID(id);
        }

        public void Remove(Account t)
        {
            _AccountDal.Delete(t);
        }

        public void Update(Account t)
        {
            _AccountDal.Update(t);
        }

    }
}
