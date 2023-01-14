using BusinnessLayer.Abstract;
using DataAceesLayer.Abstract;
using DataAceesLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class MovieManager : IMovieService
    {
        IMovieDal _movieDal;


        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public void Add(Movie movie)
        {
            _movieDal.Insert(movie);
        }

        public List<Movie> GetAllList()
        {
            return _movieDal.GetListAll();
        }

        public Movie GetById(int id)
        {
            return _movieDal.GetByID(id);
        }

        public void Remove(Movie movie)
        {
            _movieDal.Delete(movie);
        }

        public void Update(Movie movie)
        {
            _movieDal.Update(movie);
        }
    }
}
