using BusinnessLayer.Abstract;
using DataAceesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class AccountKindManager : IAccountKindService
    {
        IAccountKindDal _accountkinddal;
        public AccountKindManager(IAccountKindDal accountKindDal)
        {
            _accountkinddal = accountKindDal;
        }

        public void Add(AccountKind accountKind)
        {
            _accountkinddal.Insert(accountKind);
        }

        public List<AccountKind> GetAllList()
        {
            return _accountkinddal.GetListAll();
        }

        public AccountKind GetById(int id)
        {
         return   _accountkinddal.GetByID(id);
        }

        public void Remove(AccountKind accountKind)
        {
            _accountkinddal.Delete(accountKind);
        }

        public void Update(AccountKind accountKind)
        {
            _accountkinddal.Update(accountKind);
        }
    }
}
