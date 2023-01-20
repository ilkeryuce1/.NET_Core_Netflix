using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		void Add(T t);
		void Remove(T t);
		void Update(T t);
		List<T> GetAllList();
		T GetById(int id);
	}
}
