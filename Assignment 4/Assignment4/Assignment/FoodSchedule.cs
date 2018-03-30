// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment
{
    /// <summary>
    /// Information about how an animal motel guest is to be fed every day.
    /// </summary>
    [Serializable]
    public class FoodSchedule : IFoodSchedule
    {
        #region Fields and properties
        /// <summary>
        /// The feeding schedule, divided into items in a list.
        /// </summary>
        private readonly List<string> _foodDescriptionList;

        /// <summary>
        /// The number of items in the feeding schedule list.
        /// </summary>
        public int Count => _foodDescriptionList.Count;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="foodList">A list of food items</param>
        public FoodSchedule(List<string> foodList)
        {
            _foodDescriptionList = new List<string>(foodList);
        }

        /// <summary>
        /// Returns the food item at the given index.
        /// </summary>
        /// <param name="index">index of the requested food item</param>
        /// <returns></returns>
        public string GetFoodItem(int index)
        {
            return _foodDescriptionList[index];
        }

        /// <summary>
        /// Provides iteration over the list that FoodSchedule is.
        /// </summary>
        /// <returns>an enumerator used in foreach loop </returns>
        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in _foodDescriptionList)
            {
                yield return item;
            }
        }

        /// <summary>
        /// Returns true if the index is a valid index for the food item list.
        /// </summary>
        /// <param name="index">to be tested</param>
        /// <returns>True if the index is valid, false otherwise.</returns>
        public bool ValidateIndex(int index)
        {
            return (0 <= index && index < Count);
        }

        /// <summary>
        /// May be used in conjunction with iteration over the FoodSchedule with foreach loops.
        /// </summary>
        /// <returns>an enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}