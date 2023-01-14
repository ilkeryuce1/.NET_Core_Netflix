using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAceesLayer.Abstract
{
    public interface IGenericDal<T> where T : class
        // T entity değerim ve calassa ait butun degerlri kullanır 
    {

        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetByID(int id);
    }
}
