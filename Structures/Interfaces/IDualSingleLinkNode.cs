namespace Structures.Interfaces
{
    public interface IDualSingleLinkNode<T> : INode<T>
    {
        IDualSingleLinkNode<T> Previous { get; set; }
        IDualSingleLinkNode<T> Next { get; set; }
    }
}
