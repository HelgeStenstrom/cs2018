// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class FoodScheduleDictionary : IFoodSchedule
    {
        Dictionary<string, string[]> foodDictionary;

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
