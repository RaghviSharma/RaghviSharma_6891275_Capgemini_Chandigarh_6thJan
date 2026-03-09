using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Application
{
    internal class UserProgramCode
    {
        public interface IFilm
        {
			string Title { get; set; }
			 string Director { get; set; }
			int Year { get; set; }
		}
        public interface IFilmLibrary
        {

        }
        public class Film:IFilm
        {
           public string Title { get; set; }
          public  string Director { get; set; }
          public  int Year { get; set; }
          public Film()
            {

            }
            public Film(string title,string director,int year)
            {
                Title = title;
                Director = director;
                Year = year;
            }

        }
       public class FilmLibrary:IFilmLibrary
        {
            private List<IFilm> films = new List<IFilm>();
            
            public void AddFilm(IFilm film)
            {
                films.Add(film);
            }
            public void RemoveFilm(string title)
            {
                films.RemoveAll(t => t.Title == title);
            }
            public List<IFilm> GetFilms()
            {
                return new List<IFilm>(films);
            }
            public List<IFilm> SearchFilms(string query)
            {
                query=query.ToLower();
                return films.Where(q => q.Director.ToLower().Contains(query) || q.Title.ToLower().Contains(query)).ToList();
            }
        }
    }
}
