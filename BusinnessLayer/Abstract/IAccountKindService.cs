using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
    public interface IAccountKindService

    {
        public void Add(AccountKind accountKind);
        public void Update(AccountKind accountKind);
        public void Remove(AccountKind accountKind);
        List<AccountKind> GetAllList();
        AccountKind GetById(int id);
       
}
    }
