using Tree.DAL.Domain.Genre;
using Tree.DAL.Repositories.Abstract;
using static Tree.DAL.TreeDAL;

namespace Tree.DAL.Repositories
{
    public class GenreRepository : IGenreRepository, IRepository<Genre>
    {
        private readonly PostgreeContext _dbContext;

        public GenreRepository(PostgreeContext dbContext)
        {
            _dbContext = dbContext;
        }

        ICollection<Genre> IGenreRepository.Genres => _dbContext.Genres.ToList();


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Genre Get(int id)
        {
            throw new NotImplementedException();
        }

        Genre IRepository<Genre>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
