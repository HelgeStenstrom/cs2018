using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class AnimalManager
    {
        // TODO: Ska skapa animal IDs, unika för varje djur (individ)
        #region Fields
        
        List<Animal> _animals;
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
      
        public AnimalManager()
        {
            _animals = new List<Animal>();
        }

        #region Methods
    
        public void AddBear()
        {
            throw new NotImplementedException();
        }

        private string NewID()
        {
            return $"A{_lastAssignedNumber++}";
        }
        
        public string[] getAllAnimalStrings()
        {
            throw new NotImplementedException();
        }

        Animal GetAnimal(int index)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "not made yet";
        }
        
        
        public static List<Type> MainTypes()
        {
            List<Type> species = new List<Type>();
            species.Add(typeof(Mammal));
            species.Add(typeof(Bird));
            return species;
        }
       
        public static List<Type> Species()
        {
            List<Type> species = new List<Type>();
            species.Add(typeof(Cat));
            species.Add(typeof(Bear));
            species.Add(typeof(Eagle));
            species.Add(typeof(Penguin));
            return species;
        }

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

        public static List<String> TypeNames(List<Type> types)
        {
            List<string> names = new List<string>();
            foreach (Type t in types)
            {
                names.Add(t.Name);
            }
            return names;
        }

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

        #endregion
    }
}
