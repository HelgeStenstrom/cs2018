namespace Assignment1
{
    /// <summary>
    /// A Mammal is an Animal.
    /// </summary>
    public abstract class Mammal : Animal
    {
        /// <summary>
        /// Constructor, called by subclass constructors. Mammals have teeth.
        /// </summary>
        /// <param name="givenId"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="toothCount"></param>
        public Mammal(string givenId, string name, Gender gender, int age, int toothCount) : base(givenId, name, gender, age)
        {
            ToothCount = toothCount;
        }

        /// <summary>
        /// Mammals have teeth, usually. This is how many they are.
        /// </summary>
        public int ToothCount { get; }

        /// <summary>
        ///  A string that represents this particular Mammal.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Has is {ToothCount} teeth.";
        }
    }
}