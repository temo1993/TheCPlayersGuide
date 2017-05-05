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
        private T[] _items;

        public PracticeList()
        {
            _items = new T[0];
        }

        public T GetItem(int index)
        {
            return _items[index];
        }

        public void Add(T newItem)
        {
            T[] newItems = new T[_items.Length + 1];
            for (int index = 0; index < _items.Length; index++)
            {
                newItems[index] = _items[index];
            }
            newItems[newItems.Length - 1] = newItem;
            _items = newItems;
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