namespace Assignment4
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {

        private List<T> temporaryList;

        private List<T> mockedDB;

        public GenericRepository()
        {
            temporaryList = new();
            mockedDB = new();
        }

        public void Add(T item)
        {
            temporaryList.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return mockedDB;
        }

        public T GetById(int id)
        {
            foreach (T item in temporaryList)
            {
                if (item.Id == id) return item;
            }
            foreach (T item in mockedDB)
            {
                if (item.Id == id) return item;
            }
            return default;
        }

        public void Remove(T item)
        {
            if (!temporaryList.Remove(item))
            {
                mockedDB.Remove(item);
            }
        }

        public void Save()
        {
            foreach (T item in temporaryList)
            {
                bool inserted = false;
                for (int i = 0; i < mockedDB.Count; i++)
                {
                    if (mockedDB[i].Id > item.Id)
                    {
                        mockedDB.Insert(i, item);
                        inserted = true;
                    }
                }
                if (!inserted) mockedDB.Add(item);
            }
            temporaryList.Clear();

        }
    }
}
