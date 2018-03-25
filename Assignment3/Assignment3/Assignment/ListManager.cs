// Helge Stenström 
// ah7875
// C# del II 2018

using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Assignment
{
    /// <summary>
    /// A manager that hosts a collection.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListManager<T> : IListManager<T>, IEnumerable<T>
    {
        /// <summary>
        /// ListManager is a list. This is the list of the list.
        /// </summary>
        private List<T> _list = new List<T>();
        
        /// <summary>
        /// The number of items in this ListManager
        /// </summary>
        public int Count => _list.Count;

        /// <summary>
        /// Add an item to the list
        /// </summary>
        /// <param name="item">item to add</param>
        /// <returns>true if successful</returns>
        public bool Add(T item)
        {
            var isNotNull = (item != null);
            if (isNotNull)    
                _list.Add(item);
            return isNotNull;
        }

        /// <summary>
        /// Replace an item in the list
        /// </summary>
        /// <param name="item">item to be swapped in</param>
        /// <param name="index">indes of item to be swapped out</param>
        /// <returns>true if successful</returns>
        public bool ChangeAt(T item, int index)
        {
            var isNotNull = (item != null);
            var isOk = isNotNull && CheckIndex(index);
            if (isOk)
                _list[index] = item;
            return isOk;
        }

        /// <summary>
        /// Return true if index is a valid index of the list.
        /// </summary>
        /// <param name="index"> to be checked</param>
        /// <returns>true if index is a valid index of the list</returns>
        public bool CheckIndex(int index)
        {
            return 0 <= index && index < Count;
        }

        /// <summary>
        /// Empty the list
        /// </summary>
        public void DeleteAll()
        {
            _list = new List<T>();
        }

        /// <summary>
        /// Delete an item in the list
        /// </summary>
        /// <param name="index">index of the item to be deleted</param>
        /// <returns>true if successful</returns>
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

        /// <summary>
        /// Returns an enumberator, so that the list becomes iterable.
        /// </summary>
        /// <returns>an enumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_list).GetEnumerator();
        }

        /// <summary>
        ///  Return an enumerator for the list.
        /// </summary>
        /// <returns>an enumerator for the list</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)_list).GetEnumerator();
        }

        /// <summary>
        /// Sort the list using the comparer given.
        /// </summary>
        /// <param name="comparer">comparer used for sorting</param>
        public void Sort(IComparer<T> comparer)
        {
            _list.Sort(comparer);
        }

        /// <summary>
        /// Return an array of all items as strings.
        /// </summary>
        /// <returns>an array of all items as strings</returns>
        public string[] ToStringArray()
        {
            return ToStringList().ToArray();
        }

        /// <summary>
        /// Return a list of all items as strings.
        /// </summary>
        /// <returns>a list of all items as strings</returns>
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