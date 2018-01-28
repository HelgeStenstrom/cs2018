using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class AnimalManager
    {
        // TODO: Ska skapa animal IDs, unika för varje djur (individ)

        List<Animal> _animals;

        public AnimalManager()
        {
            _animals = new List<Animal>();
        }

        public void AddBear()
        {
            throw new NotImplementedException();
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


    }
}
