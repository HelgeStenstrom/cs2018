// Helge Stenström 
// ah7875
// C# del II 2018

namespace Assignment2
{
    /// <summary>
    /// The Cat is a Mammal.
    /// </summary>
    public class Cat : Mammal
    {
        /// <summary>
        /// Constructor. Cats eat mice, that's what they are good for. Otherwise, they are just normal Mammals.
        /// </summary>
        /// <param name="givenId"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age">in years.</param>
        /// <param name="toothCount"></param>
        /// <param name="miceEaten"></param>
        public Cat(string givenId, string name, Gender gender, int age, int toothCount, int miceEaten) : base(givenId, name, gender, age, toothCount)
        {
            MiceEaten = miceEaten;
        }

        /// <summary>
        /// The number of mice this cat has eaten so far.
        /// </summary>
        private int MiceEaten { get; }

        /// <summary>
        /// A string that represents this particular cat.
        /// </summary>
        /// <returns></returns>        
        public override string ToString()
        {
            return $"{base.ToString()} Has eaten {MiceEaten} mice.";
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