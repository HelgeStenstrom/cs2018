// Helge Stenström 
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

        /// <summary>
        /// Data to fill a ListView, one animal per item in the list.
        /// </summary>
        public IEnumerable<string[]> AnimalssAsRows => this.Select(animal => animal.RowStrings).ToList();

    }
}
