// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections.Generic;

namespace Assignment
{
    [Serializable]
    public class Bear : Mammal
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="toothCount">The number of teeth this bear has.</param>
        /// <param name="blueBerriesEaten">The number of blueberries this bear has eatin so far.</param>
        public Bear(string name, Gender gender, int age, int toothCount, int blueBerriesEaten) : 
            base(name, gender, age, toothCount)
        {
            BlueBerriesEaten = blueBerriesEaten;
            FoodSchedule = new FoodSchedule(new List<string>(){"Blåbär till frukost", "Älg till lunch"});
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"> Bear to be copied.</param>
        public Bear(Bear other) : base(other)
        {
            this.BlueBerriesEaten = other.BlueBerriesEaten;
        }

        /// <summary>
        /// Property, the number of blueberries this bear has eatin so far.
        /// </summary>
        private int BlueBerriesEaten { get; }

        /// <summary>
        /// A string that represents this particular bear.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()} Has eaten {BlueBerriesEaten} blueberries,";
        }

        /// <summary>
        /// Clone this animal. 
        /// </summary>
        /// <returns>a copy of this animal</returns>
        public override IAnimal Clone()
        {
            return new Bear(this);
        }

        /// <summary>
        /// Returns the eater type of this animal.
        /// </summary>
        /// <returns>the eater type of this animal</returns>
        public override EaterType GetEaterType()
        {
            return EaterType.Omnivore;
        }
    }
}