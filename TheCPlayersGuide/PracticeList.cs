using System;
using System.Collections;

namespace TheCPlayersGuide
{
    public class PracticeList<T> : IEnumerable where T : class, IComparable, new()
        // Any Type that is Class(Reference Type), implements IComparable, and has
        // parameterless constuctor. (use _where T:struct_ to specify that T has to be value type i.e struct)
        // When we use two gener. type parameters we can specify that one must be derived from another _where T : U_.
        // So T has be a child of U
    {
        private T[] items;

        public PracticeList()
        {
            items = new T[0];
        }

        public T GetItem(int index)
        {
            return items[index];
        }

        public void Add(T newItem)
        {
            T[] newItems = new T[items.Length + 1];
            for (int index = 0; index < items.Length; index++)
            {
                newItems[index] = items[index];
            }
            newItems[newItems.Length - 1] = newItem;
            items = newItems;
        }

        public T LoadObject(string fileName)
        {
            throw new NotImplementedException("Method has to be implemented!!!");
        }
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}