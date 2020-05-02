using Structures.Interfaces.Simple;

namespace Structures.Nodes
{
    public class DualLinkNode<T> : IDualLinkNode<T>
    {
        public IDualLinkNode<T> Previous { get; set; }
        public IDualLinkNode<T> Next { get; set; }
        public T Content { get; set; }

        public DualLinkNode(T value)
        {
            Content = value;
        }
    }
}

