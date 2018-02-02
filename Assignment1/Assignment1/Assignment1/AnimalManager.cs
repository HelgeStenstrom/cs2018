using System;
using System.Collections.Generic;

namespace Assignment1
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
        public List<string[]> AnimalssAsRows
        {
            get
            {
                List<string[]> l = new List<string[]>();
                foreach (Animal animal in _animals)
                {
                    l.Add(animal.RowStrings);
                }
                return l;
            }
        }

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
        /// Add an animal to the list of animals. The animal is created from the parameters given, and put in the list.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="categoryProperty"></param>
        /// <param name="speciesProperty"></param>
        /// <param name="species"></param>
        /// <exception cref="NotImplementedException"></exception>
        internal void AddAnimal(string name, int age, Gender gender, string categoryProperty, string speciesProperty, string species)
        {
            int toothcount, numberEaten;
            double wingspan, speed;
            
            switch (species)
            {
                case "Bear":
                    if (int.TryParse(categoryProperty, out toothcount))
                    {
                        if (int.TryParse(speciesProperty, out numberEaten))
                            _animals.Add(new Bear(NewID(), name, gender, age, toothcount, numberEaten));
                    }                   
                    break;
                case "Cat":
                    if (int.TryParse(categoryProperty, out toothcount))
                    {
                        if (int.TryParse(speciesProperty, out numberEaten))
                            _animals.Add(new Cat(NewID(), name, gender, age, toothcount, numberEaten));
                    }
                    break;
                case "Eagle":
                    if (double.TryParse(categoryProperty, out wingspan))
                    {
                        if (double.TryParse(speciesProperty, out speed))
                            _animals.Add(new Eagle(NewID(), name, gender, age, wingspan, speed));
                    }
                    break;
                case "Penguin":
                    if (double.TryParse(categoryProperty, out wingspan))
                    {
                        if (double.TryParse(speciesProperty, out speed))
                            _animals.Add(new Penguin(NewID(), name, gender, age, wingspan, speed));
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// A new ID string is generated each time this function is called, starting with A1000.
        /// </summary>
        /// <returns>The ID string.</returns>
        private static string NewID()
        {
            return $"A{_lastAssignedNumber++}";
        }

        /// <summary>
        /// Returns a subset of the list of animals. For example, all mammals can be returned.
        /// </summary>
        /// <param name="baseType">The type of the animals to return. A class in the Animal class hierarchy.</param>
        /// <returns>All animals passing the selection criterium.</returns>
        public static List<Type> OfCategory(Type baseType)
        {
            List<Type> subtypes = new List<Type>();
            foreach (Type t in Species())
            {
                if (t.IsSubclassOf(baseType))
                    subtypes.Add(t);
            }
            return subtypes;
        }

        /// <summary>
        /// Return a list of animal species supported by this program.
        /// </summary>
        /// <returns></returns>
        public static List<Type> Species()
        {
            List<Type> species = new List<Type>();
            species.Add(typeof(Cat));
            species.Add(typeof(Bear));
            species.Add(typeof(Eagle));
            species.Add(typeof(Penguin));
            return species;
        }

        /// <summary>
        /// Given a list of types (classes), return a list of their names.
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public static List<String> TypeNames(List<Type> types)
        {
            List<string> names = new List<string>();
            foreach (Type t in types)
            {
                names.Add(t.Name);
            }
            return names;
        }

        #endregion
    }
}
