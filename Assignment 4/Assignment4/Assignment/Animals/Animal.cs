﻿// Helge Stenström 
// ah7875
// C# del II 2018

using System;

namespace Assignment
{
    [Serializable]
    public abstract class Animal : IAnimal
    {
        #region Fields

        /// <summary>
        /// ID numbers are taken from this value value, which is updated one each use.
        /// </summary>
        private static int _lastAssignedIdNumber = 1000; // We give each individual animal a unique number, starting at 1000.

        /// <summary>
        /// How this animal is to be fed each day
        /// </summary>
        protected IFoodSchedule FoodSchedule;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for an animal, called by subclasses.
        /// The Animal class will itself maintain a unique ID string, 
        /// in addition to the one given by the AnimalManager.
        /// </summary>
        /// <param name="name">The name of the animal, free format.</param>
        /// <param name="gender">The gender of the animal</param>
        /// <param name="age">The age of the animal, in whole years.</param>
        protected Animal(string name, Gender gender, int age)
        {
            Id = $"ID{_lastAssignedIdNumber++}"; // Uniqueness is guaranteed by this line
            Name = name;
            Gender = gender;
            Age = age;
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        protected Animal(Animal other)
        {
            Id = other.Id;
            Name = other.Name;
            Age = other.Age;
            Gender = other.Gender;
            FoodSchedule = other.FoodSchedule;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The unique identification of the animal. Unique in this program, per run, at least.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Identification of the animal. Uniqueness maintained by AnimalManager.
        /// </summary>
        public string AltId { get; set; }

        /// <summary>
        /// The age of the animal.
        /// </summary>
        public int Age { get; }

        /// <summary>
        /// The gender (or sex) of the animal
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Strings used to fill a row in a ListView. These must match the order set on the columns in MainForm.
        /// </summary>
        public string[] RowStrings => new[]
        {
            AltId,
            Name,
            Age.ToString(),
            Gender.ToString(),
            GetSpecies(),
            ToString()
        };

        /// <summary>
        /// The name of the individual animal
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        #endregion

        #region Methods
        
        /// <summary>
        /// Make a clone of this animal. The clone has the same ID number.
        /// </summary>
        /// <returns></returns>
        public abstract IAnimal Clone();

        /// <summary>
        /// Returns the eater type of the animal.
        /// </summary>
        /// <returns>the eater type of the animal</returns>
        public abstract EaterType GetEaterType();

        /// <summary>
        /// Returns the food schedule of the animal.
        /// </summary>
        /// <returns>the food schedule of the animal</returns>
        public IFoodSchedule GetFoodSchedule()
        {
            return FoodSchedule;
        }

        /// <summary>
        /// Returns the species of the animal.
        /// </summary>
        /// <returns>the species of the animal</returns>
        public string GetSpecies()
        {
            return GetType().Name;
        } 

        #endregion
    }
}
