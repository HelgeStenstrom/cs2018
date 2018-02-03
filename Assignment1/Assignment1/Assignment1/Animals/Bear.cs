namespace Assignment1
{
    public class Bear : Mammal
    {
        public Bear(string givenId, string name, Gender gender, int age, int toothCount, int blueBerriesEaten) : base(givenId, name, gender, age, toothCount)
        {
            BlueBerriesEaten = blueBerriesEaten;
        }

        private int BlueBerriesEaten { get; }

        public override string ToString()
        {
            return $"{base.ToString()} Has eaten {BlueBerriesEaten} blueberries,";
        }
    }
}