namespace Assignment4
{
    public class MyList<T> : List<T>, IMyList<T>
    {
        public new void Add(T element)
        {
            base.Add(element);
        }

        public T Remove(int index)
        {
            T element = base[index];
            base.RemoveAt(index);
            return element;
        }

        public new bool Contains(T element)
        {
            return base.Contains(element);
        }

        public new void Clear()
        {
            base.Clear();
        }

        public void InsertAt(T element, int index)
        {
            base.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            base.RemoveAt(index);
        }

        public T Find(int index)
        {
            if (index >= base.Count) return default;
            return base[index];
        }

    }
}
