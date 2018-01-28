namespace Assignment1
{
    public class Bird : Animal
    {
        private double wingSpan;

        public override string Abstrakt()
        {
            throw new System.NotImplementedException();
        }

        public override string Virtuell()
        {
            return "Bird";
        }
    }
}