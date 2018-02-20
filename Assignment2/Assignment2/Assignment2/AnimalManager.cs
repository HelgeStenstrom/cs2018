// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Assignment2
{
    /// <summary>
    /// The AnimalManager is essentially a list of animals, with a few extra functions.
    /// </summary>
    public class AnimalManager
    {
        // TODO: Ska skapa animal IDs, unika för varje djur (individ)
        #region Fields
        
        private readonly List<Animal> _animals;
        private static int _lastAssignedNumber = 1000;
        #endregion
        
        #region Properties
        
        /// <summary>
        /// Data to fill a ListView, one animal per item in the list.
        /// </summary>
        public IEnumerable<string[]> AnimalssAsRows => _animals.Select(animal => animal.RowStrings).ToList();

        #endregion
      
        /// <summary>
        /// The AnimalManager is essentially a list of animals, with a few extra functions.
        /// This is the default constructor.
        /// </summary>
        public AnimalManager()
        {
            _animals = new List<Animal>();
        }

        #region Methods

        /// <summary>
        /// Den nya varianten.
        /// </summary>
        /// <param name="name"></param>
        public void AddAnimal(Animal name)
        {
            _animals.Add(name);
        }

        /// <summary>
        /// Add an animal to the list of animals. The animal is created from the parameters given, and put in the list.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="categoryProperty"></param>
        /// <param name="speciesProperty"></param>
        /// <param name="species"></param>
        /// <exception cref="NotImplementedException"></exception>
        [Obsolete("Use the variant which takes an animal instead.")]
        public void AddAnimal(string name, int age, Gender gender, string categoryProperty, string speciesProperty, string species)
        {
            int toothcount, numberEaten;
            double wingspan, speed;
            
            switch (species)
            {
                case "Bear":
                    if (int.TryParse(categoryProperty, out toothcount))
                    {
                        if (int.TryParse(speciesProperty, out numberEaten))
                            _animals.Add(new Bear(name, gender, age, toothcount, numberEaten));
                    }                   
                    break;
                case "Gnu":
                    if (int.TryParse(categoryProperty, out toothcount))
                    {
                        if (int.TryParse(speciesProperty, out numberEaten))
                            _animals.Add(new Gnu(name, gender, age, toothcount, numberEaten));
                    }
                    break;
                case "Eagle":
                    if (double.TryParse(categoryProperty, out wingspan))
                    {
                        if (double.TryParse(speciesProperty, out speed))
                            _animals.Add(new Eagle(name, gender, age, wingspan, speed));
                    }
                    break;
                case "Penguin":
                    if (double.TryParse(categoryProperty, out wingspan))
                    {
                        if (double.TryParse(speciesProperty, out speed))
                            _animals.Add(new Penguin(name, gender, age, wingspan, speed));
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

    
        
        public void SortBy(string sortCriteria)
        {
            IComparer<Animal> c; // = new AnimalBase.SortByName();
            switch (sortCriteria)
            {
                case "Age":
                    c = new SortByAge();
                    break;
                case "ID":
                    c = new SortById();
                    break;
                case "Name":
                    c = new SortByName();
                    break;
                case "no sort":
                    return;
                default:
                    throw new NotImplementedException();
            }
            _animals.Sort(c);
        }

        /// <summary>
        /// A new ID string is generated each time this function is called, starting with A1000.
        /// </summary>
        /// <returns>The ID string.</returns>
        [Obsolete] private static string NewId()
        {
            return $"A{_lastAssignedNumber++}";
        }

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

        public Animal GetAnimal(int index)
        {
            return _animals[index].Clone();
        }

        #endregion

        #region Sorter classes (helpers)

        private class SortById : IComparer<Animal>
        {
            public int Compare(Animal animal1, Animal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                Debug.Assert(a1 != null, nameof(a1) + " != null");
                Debug.Assert(a2 != null, nameof(a2) + " != null");
                return (string.CompareOrdinal(a1.Id, a2.Id));
            }
        }

        private class SortByName : IComparer<Animal>
        {
            public int Compare(Animal animal1, Animal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                Debug.Assert(a1 != null, nameof(a1) + " != null");
                Debug.Assert(a2 != null, nameof(a2) + " != null");
                return (string.CompareOrdinal(a1.Name, a2.Name));
            }
        }


        private class SortByAge : IComparer<Animal>
        {
            public int Compare(Animal animal1, Animal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                Debug.Assert(a1 != null, nameof(a1) + " != null");
                Debug.Assert(a2 != null, nameof(a2) + " != null");
                return (a1.Age.CompareTo(a2.Age));
            }
        }
        #endregion        
    }
    

}
