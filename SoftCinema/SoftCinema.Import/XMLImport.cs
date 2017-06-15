using ImportServices;
using SoftCinema.DTOs;

namespace SoftCinema.Import
{
    public class XMLImport
    {
        private readonly CinemaImportService cinemaImportService;
        private readonly MovieImportService movieImportService;
        private readonly AuditoriumImportService auditoriumImportService;

        public XMLImport()
        {
            this.cinemaImportService = new CinemaImportService();
            this.movieImportService = new MovieImportService();
            this.auditoriumImportService = new AuditoriumImportService();
        }

        public void ImportCinemas()
        {
            CinemaDtoCollection cinemaDtos = cinemaImportService.DeserializeCinemas(DataPaths.CinemasXml);
            cinemaImportService.ImportCinemasCollection(cinemaDtos);

        }

        public void ImportMovies()
        {
            MovieDtoCollection movieDtos = movieImportService.DeserializeMovies(DataPaths.MoviesXml);
            movieImportService.ImportMoviesCollection(movieDtos);

        }

        public void ImportAuditoriums()
        {
            AuditoriumDtoCollection auditoriumDtos =
                auditoriumImportService.DeserializeAuditoriums(DataPaths.AuditoriumsXml);
            auditoriumImportService.ImportAuditoriumCollection(auditoriumDtos);
        }
    }
}
