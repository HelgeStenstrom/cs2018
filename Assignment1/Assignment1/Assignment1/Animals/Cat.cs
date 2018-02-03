namespace Assignment1
{
    public class Cat : Mammal
    {
        public Cat(string givenId, string name, Gender gender, int age, int toothCount, int miceEaten) : base(givenId, name, gender, age, toothCount)
        {
            MiceEaten = miceEaten;
        }

        private int MiceEaten { get; }

        
        public override string ToString()
        {
            return $"{base.ToString()} Has eaten {MiceEaten} mice.";
        }
    }
}