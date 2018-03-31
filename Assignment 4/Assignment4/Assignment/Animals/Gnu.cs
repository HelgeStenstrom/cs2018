// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections.Generic;

namespace Assignment
{
    /// <summary>
    /// The Gnu is a Mammal.
    /// </summary>
    [Serializable]
    public class Gnu : Mammal
    {
        /// <summary>
        /// Constructs a gnu.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age">in years.</param>
        /// <param name="toothCount"></param>
        /// <param name="tonsEaten"> the amount of grass this gnu has eaten.</param> 
        public Gnu(string name, Gender gender, int age, int toothCount, int tonsEaten) : base(name, gender, age, toothCount)
        {
            TonsEaten = tonsEaten;
            FoodSchedule = new FoodSchedule(new List<string> { "Gräs till frukost", "Gräs till lunch" });
        }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="other">a Gnu to be copied</param>
        public Gnu(Gnu other) : base(other)
        {
            TonsEaten = other.TonsEaten;
        }

        /// <summary>
        /// The amount of grass this gnu has eaten so far.
        /// </summary>
        private int TonsEaten { get; }

        /// <summary>
        /// A string that represents this particular gnu.
        /// </summary>
        /// <returns></returns>        
        public override string ToString()
        {
            return $"{base.ToString()} Has eaten {TonsEaten} tons of grass.";
        }

        /// <summary>
        /// Clone this animal.
        /// </summary>
        /// <returns>a copy of this animal.</returns>
        public override IAnimal Clone()
        {
            return new Gnu(this);
        }

        /// <summary>
        /// Returns the eater type of this animal.
        /// </summary>
        /// <returns>the eater type of this animal</returns>
        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;
        }
    }
}