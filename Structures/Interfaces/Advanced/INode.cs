namespace Structures.Interfaces.Advanced
{
    /// <summary>
    /// A generic node
    /// </summary>
    /// <typeparam name="T">A generic type attributed to a node</typeparam>
    public interface INode<T>
    {
        /// <summary>
        /// The node's content
        /// </summary>
        T Content { get; set; }
    }

}
