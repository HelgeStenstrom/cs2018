// Helge Stenström 
// ah7875
// C# del II 2018

namespace Assignment
{
    /// <summary>
    /// A Mammal is an Animal.
    /// </summary>
    public abstract class Mammal : Animal
    {
        /// <summary>
        /// Constructor, called by subclass constructors. Mammals have teeth.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="toothCount"></param>
        public Mammal(string name, Gender gender, int age, int toothCount) : base(name, gender, age)
        {
            ToothCount = toothCount;
        }

        public Mammal(Mammal other) : base(other)
        {
            this.ToothCount = other.ToothCount;
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