namespace Structures.Interfaces
{
    public interface ISingleLinkNode<T> : INode<T>
    {
        ISingleLinkNode<T> Next { get; }
    }
}
