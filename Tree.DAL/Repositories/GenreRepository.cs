using Tree.DAL.Domain.Genre;
using Tree.DAL.Domain.Node;
using Tree.DAL.Repositories.Abstract;

namespace Tree.DAL.Repositories
{
    public class GenreRepository : IGenreRepository, IRepository<Genre>
    {
        public ICollection<Genre> Genres => throw new NotImplementedException();

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Node Get(int id)
        {
            throw new NotImplementedException();
        }

        Genre IRepository<Genre>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
