// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    public class FoodSchedule : IEnumerable<string>
    {
        #region Fields and properties
        private List<string> _foodDescriptionList;
        public int Count => _foodDescriptionList.Count;
        #endregion


        public FoodSchedule()
        {
            _foodDescriptionList = new List<string>();
        }

        public FoodSchedule(List<string> foodList)
        {
            _foodDescriptionList = new List<string>(foodList);
        }

        public bool AddFoodScheduleItem(string item)
        {
            throw new System.NotImplementedException();
        }

        public bool ChangeFoodScheduleItem(string item, int index)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteFoodScheduleItem(int index)
        {
            throw new System.NotImplementedException();
        }

        public string GetFoodSchedule(int index)
        {
            return _foodDescriptionList[index];
        }

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < _foodDescriptionList.Count; i++)
            {
                yield return _foodDescriptionList[i];
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool ValidateIndex(int index)
        {
            return (0 <= index && index < Count);
        }
    }
}