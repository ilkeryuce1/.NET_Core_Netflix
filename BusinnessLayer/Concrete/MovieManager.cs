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

		public void Add(Movie t)
		{
			_movieDal.Insert(t);		}

		public List<Movie> GetAllList()
		{
			return _movieDal.GetListAll();
		}

		public Movie GetById(int id)
		{
			return _movieDal.GetByID(id);		}

		public void Remove(Movie t)
		{
			_movieDal.Delete(t);


		}
			public void Update(Movie t)
		{
			_movieDal.Update(t);		}
	}
}
