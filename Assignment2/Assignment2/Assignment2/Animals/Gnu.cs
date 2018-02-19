﻿// Helge Stenström 
// ah7875
// C# del II 2018

using System.Collections.Generic;

namespace Assignment2
{
    /// <summary>
    /// The Gnu is a Mammal.
    /// </summary>
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
            FoodSchedule = new FoodSchedule(new List<string>() { "Gräs till frukost", "Gräs till lunch" });
        }

        public Gnu(Gnu other) : base(other)
        {
            this.TonsEaten = other.TonsEaten;
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

        public override Animal Clone()
        {
            return new Gnu(this);
        }

        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;
        }
    }
}