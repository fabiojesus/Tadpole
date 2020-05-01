namespace Structures.Interfaces.Advanced
{
    public interface IHasPreviousLinkNode<T, T1> where T1 : INode<T>
    {
        T1 Previous { get; }
    }
}
