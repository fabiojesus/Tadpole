namespace Structures.Interfaces.Lists
{
    public interface ISingleLinkedList<T>
    {
        /// <summary>
        /// Adds a new value at the head of the list
        /// </summary>
        /// <param name="value">the value to be inserted in</param>
        public void AddFirst(T value);

        /// <summary>
        /// Adds a new value at the tail of the list
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value);

        /// <summary>
        /// Removes the element in the head of the list
        /// </summary>
        /// <returns>the value of the removed element</returns>
        public T RemoveFirst();

        /// <summary>
        /// Removes the element at the tail of the list
        /// </summary>
        /// <returns>the value of the removed element</returns>
        public T RemoveLast();
    }
}
