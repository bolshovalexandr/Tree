using Tree.DAL.Domain.Node;
using Tree.DAL.Repositories.Abstract;

namespace Tree.DAL.Repositories
{
    public class NodeRepository : INodeRepository, IRepository<Node>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Node Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
