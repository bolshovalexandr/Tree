namespace Tree.DAL.Repositories.Abstract
{
    public interface IRepository<T>
    {
        public T Get(int id);
        public void Delete(int id);
    }
}
