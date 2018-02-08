// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections;

namespace Assignment2
{
    public abstract class AnimalBase : Animal, IComparable
    {
        #region Fields
        private int Age { get; }
        public Gender Gender { get; set; }
        private string Name { get; }
        private readonly string _givenId; // It's the AnimalManager's responsibility to ensure this ID is unique.
        public string Id { get; } 
        private static int _lastAssignedIdNumber = 1000; // We give each individual animal a unique number, starting at 1000.
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
        /// Strings used to fill a row in a ListView.
        /// </summary>
        public string[] RowStrings => new[] 
        {
            _givenId,
            Id,
            Name,
            Age.ToString(),
            Gender.ToString(),
            GetType().Name,       
            ToString()
        };

        //public string ID { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        string Animal.Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        #endregion

        /// <summary>
        /// Constructor for an animal, called by subclasses.
        /// The Animal class will itself maintain a unique ID string, 
        /// in addition to the one given by the AnimalManager.
        /// </summary>
        /// <param name="givenId">It's the caller's responsibility that this value is unique.</param>
        /// <param name="name">The name of the animal, free format.</param>
        /// <param name="gender">The gender of the animal</param>
        /// <param name="age">The age of the animal, in whole years.</param>
        protected AnimalBase(string givenId, string name, Gender gender, int age)
        {
            Id = $"B{_lastAssignedIdNumber++}"; // Uniqueness is guaranteed by this line
            _givenId = givenId;
            Name = name;
            Gender = gender;
            Age = age;
        }

        public EaterType GetEaterType()
        {
            throw new System.NotImplementedException();
        }

        public FoodSchedule GetFoodSchedule()
        {
            throw new System.NotImplementedException();
        }

        public string GetSpecies()
        {
            return this.GetType().Name;
        }



        #region Methods
        // No methods defined.
        #endregion

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public class SortByName : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                var a1 = (Animal) x;
                var a2 = (Animal) y;
                return (string.Compare(a1.Name, a2.Name));
            }
        }

    }
}
