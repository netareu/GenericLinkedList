using System.Collections;

namespace GenericLinkedList
{
    public class MyList<T> : ICollection<T>
    {
        public int Count { get; }
        public bool IsReadOnly { get; }
        public MyItem<T> MyItem { get; set; }

        public void Add(T item)
        {
            MyItem<T> currentItem = MyItem;
            while (currentItem.NextItem != null)
            {
                currentItem = (MyItem<T>)currentItem.NextItem;
            }
            MyItem.NextItem = new MyItem<T>(item, null);
        }

        public void Clear()
        {
            MyItem = null;
        }

        public bool Contains(T item)
        {
            MyItem<T> currentItem = MyItem;
            while (currentItem != null)
            {
                if (currentItem.Content.Equals(item))
                {
                    return true;
                }
                currentItem = (MyItem<T>)currentItem.NextItem;
            }
            return false;
        }

        public bool Remove(T item)
        {
            MyItem<T> currentItem = MyItem;
            while (currentItem != null || !currentItem.NextItem.Content.Equals(item))
            {
                currentItem = (MyItem<T>)currentItem.NextItem;
            }
            if (currentItem.NextItem.Content.Equals(item))
            {
                currentItem.NextItem = currentItem.NextItem.NextItem;
                return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
