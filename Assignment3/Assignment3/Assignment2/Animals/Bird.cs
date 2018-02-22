// Helge Stenström 
// ah7875
// C# del II 2018

namespace Assignment2
{
    /// <summary>
    /// An animal which is a bird. Base class for birds.
    /// </summary>
    public abstract class Bird : AnimalBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="wingSpan"></param>
        public Bird(string name, Gender gender, int age, double wingSpan) : base(name, gender, age)
        {
            WingSpan = wingSpan;
        }
        
        /// <summary>
        /// Copy constructor. 
        /// </summary>
        /// <param name="other">a copy of this Bird</param>
        public Bird(Bird other) : base(other)
        {
            this.WingSpan = other.WingSpan;
        }

        /// <summary>
        /// The wing span in cm, for this particular bird.
        /// </summary>
        public double WingSpan { get; }

        /// <summary>
        /// A string that represents this particular bird.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Wingspan is {WingSpan} cm.";
        }

    }
}