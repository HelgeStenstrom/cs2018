// Helge Stenström 
// ah7875
// C# del II 2018

using System.Collections.Generic;

namespace Assignment
{
    /// <summary>
    /// Interface for implementation by manager classes hosting a collection.
    /// </summary>
    /// <typeparam name="T">object type</typeparam>
    public interface IListManager<T>
    {

        #region All Assignment 3 method definitions

        /// <summary>
        /// Returns the number of items in the collection
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Adds an object to the collection.
        /// </summary>
        /// <param name="item">object type</param>
        /// <returns></returns>
        bool Add(T item);

        /// <summary>
        /// Replaces an item in the collection.
        /// </summary>
        /// <param name="item">item to insert in the collection</param>
        /// <param name="index">index of item to be replaced</param>
        /// <returns></returns>
        bool ChangeAt(T item, int index);

        /// <summary>
        /// Checks the validity of the index.
        /// </summary>
        /// <param name="index">index to be validated</param>
        /// <returns>true if the index is valid, false otherwise.</returns>
        bool CheckIndex(int index);

        /// <summary>
        /// Delete all items in the collection.
        /// </summary>
        void DeleteAll();

        /// <summary>
        /// Delete the item at the index.
        /// </summary>
        /// <param name="index">index of the item to be deleted.</param>
        /// <returns>true if successful, false otherwise.</returns>
        bool DeleteAt(int index);       

        /// <summary>
        /// Returns the item (or a copy thereof) at the index
        /// </summary>
        /// <param name="index">index of the item to be returned.</param>
        /// <returns>the item (or a copy thereof) at the index</returns>
        T GetAt(int index);

        /// <summary>
        /// Returns an array of representative strings of all items in the collection.
        /// </summary>
        /// <returns>an array of representative strings of all items in the collection</returns>
        string[] ToStringArray();

        /// <summary>
        /// Returns a list of representative strings of all items in the collection.
        /// </summary>
        /// <returns>a list of representative strings of all items in the collection</returns>
        List<string> ToStringList();
        
        /// <summary>
        /// Make objects of this class comparable.
        /// </summary>
        /// <param name="comparer"></param>
        void Sort(IComparer<T> comparer);

        #endregion

        #region Assignment 4 serialization
        void BinarySerialize(string fileName);
        void BinaryDeserialize(string fileName);
        void XmlSerialize(string fileName);
        #endregion
    }
}
