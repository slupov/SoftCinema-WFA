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

        public static void ImportMovies()
        {
            MovieDTOCollection movieDtos = MovieImportService.DeserializeMovies(DataPaths.MoviesXml);
            MovieImportService.ImportMoviesCollection(movieDtos);

        }

        public static void ImportAuditoriums()
        {
            AuditoriumDTOCollection auditoriumDtos =
                AuditoriumImportService.DeserializeAuditoriums(DataPaths.AuditoriumsXml);
            AuditoriumImportService.ImportAuditoriumCollection(auditoriumDtos);
        }
    }
}
