using Tree.DAL.Domain.Genre;
using Tree.DAL.Repositories.Abstract;

namespace Tree.Logic;

public class GenreService
{
    private readonly IGenreRepository _genreRepository;
    public GenreService(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;
    }

    public ICollection<Genre> GenresList()
    {
        return _genreRepository.Genres;
    }

}