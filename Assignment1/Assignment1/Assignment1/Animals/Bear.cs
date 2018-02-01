namespace Assignment1
{
    public class Bear : Mammal
    {
        public int BlueBerriesEaten { get; }

        public Bear(string givenId) : base(givenId)
        {
            BlueBerriesEaten = 17;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()} Has eaten {BlueBerriesEaten} blueberries,";
        }
    }
}