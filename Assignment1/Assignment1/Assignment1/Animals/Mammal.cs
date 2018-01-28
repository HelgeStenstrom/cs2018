namespace Assignment1
{
    public class Mammal : Animal
    {
        public int ToothCount { get; }

        public override string Abstrakt()
        {
            throw new System.NotImplementedException();
        }

        public Mammal(string givenId) : base(givenId)
        {
        }
    }
}