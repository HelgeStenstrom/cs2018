// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment
{
    /// <summary>
    /// The scedule for feeding a guest in the animal motel, using a dictionary to hold the data.
    /// Not used, actually.
    /// </summary>
    public class FoodScheduleDictionary : IFoodSchedule
    {
        /// <summary>
        /// This dictionarly would hold a list of ingredient for each unique key. 
        /// I don't use it, because I haven't figured out what to use as key. 
        /// Perhaps the animal ID?
        /// </summary>
        Dictionary<string, string[]> foodDictionary;

        /// <summary>
        /// This method is needed for the FoodScheduleDictionary to fulfill the IEnumberable interface, 
        /// but I don't use it.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// This method is needed for the FoodScheduleDictionary to fulfill the IEnumberable interface.
        /// It allows puting the schecule in an foreach loop.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
