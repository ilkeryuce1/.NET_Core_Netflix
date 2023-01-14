using DataAceesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
    public interface IMovieKindService 
    {
        void Add(MovieKind movieKind);
        void Remove(MovieKind movieKind);
        void Update(MovieKind movieKind);
        List<MovieKind> GetAllList();
        MovieKind GetById(int id);
    }
}
