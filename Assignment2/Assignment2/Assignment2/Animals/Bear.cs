// Helge Stenström 
// ah7875
// C# del II 2018

namespace Assignment2
{
    public class Bear : Mammal
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="givenId"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="toothCount">The number of teeth this bear has.</param>
        /// <param name="blueBerriesEaten">The number of blueberries this bear has eatin so far.</param>
        public Bear(string givenId, string name, Gender gender, int age, int toothCount, int blueBerriesEaten) : 
            base(givenId, name, gender, age, toothCount)
        {
            BlueBerriesEaten = blueBerriesEaten;
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

        public override EaterType GetEaterType()
        {
            throw new System.NotImplementedException();
        }

        public override FoodSchedule GetFoodSchedule()
        {
            throw new System.NotImplementedException();
        }

        public override string GetSpecies()
        {
            throw new System.NotImplementedException();
        }
    }
}