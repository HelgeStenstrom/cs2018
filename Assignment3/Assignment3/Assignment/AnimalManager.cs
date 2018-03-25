// Helge Stenström 
// ah7875
// C# del II 2018

using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    /// <summary>
    /// The AnimalManager is essentially a list of animals, with a few extra functions.
    /// </summary>
    public class AnimalManager : ListManager<IAnimal>
    {
        /// <summary>
        /// The number in turn to make a unique ID from.
        /// </summary>
        private static int _lastAssignedNumber = 1000;


        /// <summary>
        /// Data to fill a ListView, one animal per item in the list.
        /// </summary>
        public IEnumerable<string[]> AnimalssAsRows => this.Select(animal => animal.RowStrings).ToList();

        /// <summary>
        /// A new ID string is generated each time this function is called, starting with A1000.
        /// </summary>
        /// <returns>The ID string.</returns>
        private static string NewId()
        {
            return $"A{_lastAssignedNumber++}";
        }

        /// <summary>
        /// Add a unique ID to the animal before it's added to the list.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public new bool Add(IAnimal animal)
        {
            animal.AltId = NewId();
            return base.Add(animal);
        }

    }
}
