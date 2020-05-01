namespace Structures.Interfaces.Advanced
{
    public interface IHasNextLinkNode<T, T1> where T1:INode<T> 
    {
        T1 Next { get; }
    }
}
