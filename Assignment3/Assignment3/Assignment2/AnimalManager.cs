﻿// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Assignment
{
    /// <summary>
    /// The AnimalManager is essentially a list of animals, with a few extra functions.
    /// </summary>
    public class AnimalManager : ListManager<IAnimal>
    {
        #region Fields

        /// <summary>
        /// The list of animals that this class maintains.
        /// </summary>
        private readonly List<IAnimal> _animals;

        #endregion

        /// <summary>
        /// The AnimalManager is essentially a list of animals, with a few extra functions.
        /// This is the default constructor.
        /// </summary>
        public AnimalManager()
        {
            _animals = new List<IAnimal>();
        }

        #region Properties

        /// <summary>
        /// Data to fill a ListView, one animal per item in the list.
        /// </summary>
        public IEnumerable<string[]> AnimalssAsRows => _animals.Select(animal => animal.RowStrings).ToList();
        
        public IEnumerable<string[]> AnimalssAsRows2
        {
            get
            {
                List<string[]> l = new List<string[]>();
                for (var i = 0; i < Count; i++)
                {
                    l.Add(GetAt(i).RowStrings);
                }
                return l;
            }
        }

        
        #endregion

        #region Methods

        /// <summary>
        /// Returns a subset of the list of animals. For example, all mammals can be returned.
        /// </summary>
        /// <param name="baseType">The type of the animals to return. A class in the Animal class hierarchy.</param>
        /// <returns>All animals passing the selection criterium.</returns>
        public static List<Type> OfCategory(Type baseType) => Species().Where(t => t.IsSubclassOf(baseType)).ToList();

        /// <summary>
        /// Return a list of animal species supported by this program.
        /// </summary>
        /// <returns></returns>
        public static List<Type> Species()
        {
            return new List<Type> {typeof(Gnu), typeof(Bear), typeof(Eagle), typeof(Penguin)};
        }

        /// <summary>
        /// Given a list of types (classes), return a list of their names.
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public static List<string> TypeNames(IEnumerable<Type> types) => types.Select(t => t.Name).ToList();

        
        /// <summary>
        /// Den nya varianten.
        /// </summary>
        /// <param name="animal"></param>
        public void AddAnimal(IAnimal animal)
        {
            _animals.Add(animal);
            Add(animal);
        }

        /// <summary>
        /// Returns the animal at the given index in the list of animals.
        /// </summary>
        /// <param name="index">the animal at the given index in the list of animals</param>
        /// <returns></returns>
        public IAnimal GetAnimal(int index)
        {
            //return GetAt(index).Clone();
            return _animals[index].Clone();
            
        }

        public void Sort(IComparer<IAnimal> comparer)
        {
            _animals.Sort(comparer);
        }


        #endregion

        #region Sorter classes (helpers)

        /// <summary>
        /// Compare animals by age.
        /// </summary>
        private class CompareByAge : IComparer<IAnimal>
        {
            public int Compare(IAnimal animal1, IAnimal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                Debug.Assert(a1 != null, nameof(a1) + " != null");
                Debug.Assert(a2 != null, nameof(a2) + " != null");
                return (a1.Age.CompareTo(a2.Age));
            }
        }

        /// <summary>
        /// Compare animals by ID
        /// </summary>
        private class CompareById : IComparer<IAnimal>
        {
            public int Compare(IAnimal animal1, IAnimal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                Debug.Assert(a1 != null, nameof(a1) + " != null");
                Debug.Assert(a2 != null, nameof(a2) + " != null");
                return (string.CompareOrdinal(a1.Id, a2.Id));
            }
        }

        /// <summary>
        /// Compare animals by name.
        /// </summary>
        private class CompareByName : IComparer<IAnimal>
        {
            public int Compare(IAnimal animal1, IAnimal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                Debug.Assert(a1 != null, nameof(a1) + " != null");
                Debug.Assert(a2 != null, nameof(a2) + " != null");
                return (string.CompareOrdinal(a1.Name, a2.Name));
            }
        }

        #endregion        
    }
    

}
