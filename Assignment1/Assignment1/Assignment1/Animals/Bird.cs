namespace Assignment1
{
    public abstract class Bird : Animal
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="givenId"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="wingSpan"></param>
        public Bird(string givenId, string name, Gender gender, int age, double wingSpan) : base(givenId, name, gender, age)
        {
            WingSpan = wingSpan;
        }

        /// <summary>
        /// The wing span in cm, for this particular bird.
        /// </summary>
        public double WingSpan { get; }

        /// <summary>
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