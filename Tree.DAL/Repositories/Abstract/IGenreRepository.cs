using Tree.DAL.Domain.Genre;

namespace Tree.DAL.Repositories.Abstract
{
    public interface IGenreRepository: IRepository<Genre>
    {
        public ICollection<Genre> Genres { get; }
    }
}
