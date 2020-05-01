using Structures.Interfaces.Advanced;

namespace Structures.Interfaces.Simple
{
    public interface ISingleLinkNode<T> : INode<T>
    {
        ISingleLinkNode<T> Next { get; set; }
    }
}
