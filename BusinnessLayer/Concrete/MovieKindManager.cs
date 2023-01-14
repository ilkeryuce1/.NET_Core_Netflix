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
    public class MovieKindManager : IMovieKindService
    {
        IMovieKindDal _ımovieKindDal;
        public MovieKindManager(IMovieKindDal movieKindDal)
        {
            _ımovieKindDal = movieKindDal;
        }

        public void Add(MovieKind movieKind)
        {
            _ımovieKindDal.Insert(movieKind);
        }

        public List<MovieKind> GetAllList()
        {
            return _ımovieKindDal.GetListAll();
        }

        public MovieKind GetById(int id)
        {
            return _ımovieKindDal.GetByID(id);
        }

        public void Remove(MovieKind movieKind)
        {
            _ımovieKindDal.Delete(movieKind);
        }

        public void Update(MovieKind movieKind)
        {
            _ımovieKindDal.Update(movieKind);
        }
    }
}
