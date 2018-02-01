namespace Assignment1
{
    public class Cat : Mammal
    {
        public int MiceEaten { get; }

        public Cat(string givenId) : base(givenId)
        {
            MiceEaten = 17;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()} Has eaten {MiceEaten} mice.";
        }
    }
}