// Helge Stenström 
// ah7875
// C# del II 2018

namespace Assignment2
{
    /// <summary>
    /// A Penguin is a Bird.
    /// </summary>
    public class Penguin : Bird
    {
        /// <summary>
        /// Constructor. Like a Bird constructor, but with an additional swimSpeed.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="wingSpan">in cm</param>
        /// <param name="swimSpeed">in knots</param>
        public Penguin(string name, Gender gender, int age, double wingSpan, double swimSpeed) : base(name, gender, age, wingSpan)
        {
            SwimSpeed = swimSpeed;
        }

        /// <summary>
        /// How fast this particular penguin can swim.
        /// </summary>
        private double SwimSpeed { get; }

        /// <summary>
        /// A string that represents this particular penguin.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()} Swim speed is {SwimSpeed} knots,";
        }


        public override Animal Clone()
        {
            throw new System.NotImplementedException();
        }
    }
}