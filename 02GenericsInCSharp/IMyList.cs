namespace Assignment4
{
    public interface IMyList<T>
    {
        /// <summary>
        /// Adds an element into the list.
        /// </summary>
        /// <param name="element"></param>
        void Add(T element);

        /// <summary>
        /// Removes the element at index specified and returns the element.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T Remove(int index);

        /// <summary>
        /// Checks whether the element exists inside the list
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool Contains(T element);

        /// <summary>
        /// Clear elements of the list.
        /// </summary>
        void Clear();

        /// <summary>
        /// Insert element into the list at position index.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="index"></param>
        void InsertAt(T element, int index);

        /// <summary>
        /// Delete element at position index.
        /// </summary>
        /// <param name="index"></param>
        void DeleteAt(int index);

        /// <summary>
        /// Find element at position index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T Find(int index);

    }
}
