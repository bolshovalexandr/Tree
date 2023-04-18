using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.DAL.Domain.Node
{
    public class Node
    {
        public int Id { get; set; }
        public int NodeId { get; set; }
        public int? Parent { get; set; }
        public string? TreePath { get; set; }
        public string? Title { get; set; }


    }
}
