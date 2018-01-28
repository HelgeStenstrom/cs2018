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


    }
}
