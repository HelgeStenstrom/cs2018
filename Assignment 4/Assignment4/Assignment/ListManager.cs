// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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

        internal void Clear()
        {
            _list.Clear();
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

        public void BinarySerialize(string fileName)
        {
            FileStream fileStream = null;
            string errorMsg;

            try
            {
                fileStream = new FileStream(fileName, FileMode.Create);
                var formatter = new BinaryFormatter();
                // TODO: bara en av dessa två.
                //formatter.Serialize(fileStream, this);
                formatter.Serialize(fileStream, _list);
            }
            // Don't catch the exception here, but in calling function. Just ensure the stream is closed.
            finally
            {
                fileStream?.Close();
            } 
        }
        
        public void AltBinarySerialize(string fileName)
        {
            using (var fileStream = new FileStream(fileName, FileMode.Create))
                new BinaryFormatter().Serialize(fileStream, _list);
        }

        public void BinaryDeserialize(string fileName)
        {
            // Det känns som om koden från Serialize-dokumentet hamar i fel klass, eller att denna metod
            // (vars signatur är given) inte är den som ska ha implementationen. Den är ju void.

            FileStream fileStream = null;
            object obj = null;

            try
            {
                if (!File.Exists(fileName))
                {
                    throw new FileNotFoundException($"The file {fileName} was not found. ");
                }

                fileStream = new FileStream(fileName, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                obj = b.Deserialize(fileStream);
            }
            // Don't catch the exception here, but in calling function. Just ensure the stream is closed.
            finally
            {
                fileStream?.Close();
            }

            _list = (List<T>) obj;
        }

	// Inspiration from https://stackoverflow.com/questions/11467240/how-to-use-streamwriter-class-properly
        public void AltBinaryDeserialize(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException($"The file {fileName} was not found. ");

            using (var fileStream = new FileStream(fileName, FileMode.Open))
                _list = (List<T>) new BinaryFormatter().Deserialize(fileStream);
        }

        public void XmlSerialize(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
