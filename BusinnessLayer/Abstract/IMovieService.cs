using DataAceesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
    public interface IMovieService
    {
        void Add(Movie movie);
        void Remove(Movie movie);
        void Update(Movie movie);
        List<Movie> GetAllList();
        Movie GetById(int id);
    }
}
