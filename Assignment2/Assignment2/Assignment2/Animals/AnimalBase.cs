// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Assignment2
{
    public abstract class AnimalBase : Animal
    {
        #region Fields
        public int Age { get; }
        public Gender Gender { get; set; }

        //public string Name { get; }
        //private readonly string _givenId; // It's the AnimalManager's responsibility to ensure this ID is unique.
        public string Id { get; } 
        private static int _lastAssignedIdNumber = 1000; // We give each individual animal a unique number, starting at 1000.
        protected FoodSchedule FoodSchedule;
        
        #endregion

        #region Properties

        /// <summary>
        /// The last assigned ID number can be used to make assumptions about what the next assigned number will be.
        /// </summary>
        private static int LastAssignedIdNumber
        {
            get => _lastAssignedIdNumber;
        }

        /// <summary>
        /// Strings used to fill a row in a ListView. These must match the order set on the columns in MainForm.
        /// </summary>
        public string[] RowStrings => new[] 
        {
            Id,
            Name,
            Age.ToString(),
            Gender.ToString(),
            GetSpecies(),       
            ToString()
        };

        public string Name
        {
            get;
            set;
        }

        #endregion

        /// <summary>
        /// Constructor for an animal, called by subclasses.
        /// The Animal class will itself maintain a unique ID string, 
        /// in addition to the one given by the AnimalManager.
        /// </summary>
        /// <param name="name">The name of the animal, free format.</param>
        /// <param name="gender">The gender of the animal</param>
        /// <param name="age">The age of the animal, in whole years.</param>
        protected AnimalBase(string name, Gender gender, int age)
        {
            Id = $"ID{_lastAssignedIdNumber++}"; // Uniqueness is guaranteed by this line
            Name = name;
            Gender = gender;
            Age = age;
        }

        protected AnimalBase(AnimalBase other)
        {
            this.Id = other.Id;
            this.Name = other.Name;
            this.Age = other.Age;
            this.Gender = other.Gender;
            this.FoodSchedule = other.FoodSchedule;
        }

        public abstract Animal Clone();

        public abstract EaterType GetEaterType();

        public FoodSchedule GetFoodSchedule()
        {
            return FoodSchedule;
        }
        public string GetSpecies()
        {
            return this.GetType().Name;
        } 

        #region Methods
        // No methods defined.
        #endregion
    }
}
