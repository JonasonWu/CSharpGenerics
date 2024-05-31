namespace Assignment4
{
    public class MyStack<T>
    {
        private List<T> list;

        public MyStack()
        {
            list = new();
        }

        public int Count()
        {
            return list.Count;
        }

        public T? Pop()
        {
            if (list.Count == 0)
            {
                return default;
            }

            T item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return item;
        }

        public void Push(T item)
        {
            list.Add(item);
        }

    }
}
