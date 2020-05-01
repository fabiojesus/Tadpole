using Structures.Interfaces.Advanced;

namespace Structures.Interfaces.Simple
{
    public interface IDualLinkNode<T> : INode<T>
    {
        IDualLinkNode<T> Previous { get; set; }
        IDualLinkNode<T> Next { get; set; }
    }
}
