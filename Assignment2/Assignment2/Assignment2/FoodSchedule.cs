using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    public class FoodSchedule
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
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        
        public bool ValidateIndex(int index)
        {
            return (0 <= index && index < Count);
        }
    }
}