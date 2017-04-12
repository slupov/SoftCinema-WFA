using System.Xml.Serialization;
using ImportServices;
using SoftCinema.DTOs;
using SoftCinema.Models;

namespace SoftCinema.Import
{
    using Data;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public static class XMLImport
    {        
        public static void ImportCinemas()
        {
            CinemaDTOCollection cinemaDtos = CinemaImportService.DeserializeCinemas(DataPaths.CinemasXml);
            CinemaImportService.ImportCinemasCollection(cinemaDtos);

        }

        public static void ImportMovies(SoftCinemaContext context)
        {
            var moviesXML = XDocument.Load("../../Resources/movies.xml");
            var movies = moviesXML.Root.Elements();

            foreach (var movie in movies)
            {
                string name = movie.Element("Name").Value;
                int length = int.Parse(movie.Element("Length")?.Value);
                float? rating = float.Parse(movie.Element("Rating")?.Value);
                string synopsis = movie.Element("Synopsis")?.Value;
                string directorName = movie.Element("DirectorName").Value;
                int releaseYear = int.Parse(movie.Element("ReleaseYear").Value);
                string releaseCountry = movie.Element("ReleaseCountry")?.Value;
                string ageRestriction = movie.Element("AgeRestriction").Value;

                context.Movies.AddOrUpdate(c => c.Name,
                    new Movie()
                    {
                        Name = name,
                        Length = length,
                        Rating = rating,
                        Synopsis = synopsis,
                        DirectorName = directorName,
                        ReleaseYear = releaseYear,
                        ReleaseCountry = releaseCountry,
                        AgeRestriction = (AgeRestriction)Enum.Parse(typeof(AgeRestriction), ageRestriction)                  
                    });
            }
            context.SaveChanges();
        }
        public static void ImportAuditoriums(SoftCinemaContext context)
        {
            var auditoriumsXML = XDocument.Load("../../Resources/auditoriums.xml");
            var auditoriums = auditoriumsXML.Root.Elements();

            foreach (var auditorium in auditoriums)
            {
                string cinemaName = auditorium.Element("CinemaName").Value;

                context.Auditoriums.Add(
                    new Auditorium()
                    {
                        Cinema = context.Cinemas.Single(c => c.Name == cinemaName),
                        Number = (byte) (context.Cinemas.Single(c => c.Name == cinemaName).Auditoriums.Count() + 1),           
                    });
            }
            context.SaveChanges();
        }
    }
}
