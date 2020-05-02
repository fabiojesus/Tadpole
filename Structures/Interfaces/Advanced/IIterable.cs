namespace Structures.Interfaces.Advanced
{
    /// <summary>
    /// An iterable behaviour for a list
    /// </summary>
    /// <typeparam name="T">The list's type</typeparam>
    public interface IIterable<T>
    {
        /// <summary>
        /// The value that is currently being iterated
        /// </summary>
        T Current { get; }

        /// <summary>
        /// A reset action to set the value as the first one
        /// </summary>
        void Reset();
    }
}
