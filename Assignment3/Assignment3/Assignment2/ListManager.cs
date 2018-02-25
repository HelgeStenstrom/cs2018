using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Assignment
{
    /// <summary>
    /// A manager that hosts a collection.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListManager<T> : IListManager<T>
    {
        private List<T> _list = new List<T>();


        public ListManager()
        {
        }

        public int Count => _list.Count;

        public bool Add(T item)
        {
            var isNotNull = (item != null);
            if (isNotNull)    
                _list.Add(item);
            return isNotNull;
        }

        public bool ChangeAt(T item, int index)
        {
            var isNotNull = (item != null);
            var isOk = isNotNull && CheckIndex(index);
            if (isOk)
                _list[index] = item;
            return isOk;
        }

        public bool CheckIndex(int index)
        {
            return 0 <= index && index < Count;
        }

        public void DeleteAll()
        {
            _list = new List<T>();
        }

        public bool DeleteAt(int index)
        {
            var isOk = CheckIndex(index);
            if (isOk)
                _list.RemoveAt(index);
            return isOk;
        }

        /// <inheritdoc />
        /// Throws an exception if the index is out of bounds.
        public T GetAt(int index)
        {
            // Calling CheckIndex is not meaningful.
            return _list[index];
        }

        public void Sort(IComparer<T> comparer)
        {
            _list.Sort(comparer);
        }
        
        public string[] ToStringArray()
        {
            return ToStringList().ToArray();
        }

        public List<string> ToStringList()
        {
            var x = new List<string>();
            foreach (var item in _list)
            {
                x.Add(item.ToString());
            }
            return x;
        }
    }
}