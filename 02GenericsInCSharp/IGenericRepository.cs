namespace Assignment4
{
    public interface IGenericRepository<T> where T : Entity
    {
        /// <summary>
        /// Add element into repository
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);

        /// <summary>
        /// Remove item from repository.
        /// </summary>
        /// <param name="item"></param>
        void Remove(T item);

        /// <summary>
        /// Save the data into the db.
        /// </summary>
        void Save();

        /// <summary>
        /// Get all the data from the db.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Get element that has the specified id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

    }
}
