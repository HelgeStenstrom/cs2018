namespace Assignment1
{
    public abstract class Animal
    {
        // TODO: data as per 3.5

        private int Age { get; }
        private Gender Gender { get; }
        private string NickName { get; }
        private string givenId; // It's the AnimalManager's responsibility to ensure this ID is unique.
        public string Id { get; } 
        private static int lastAssignedIdNumber = 1000; // We give each individual animal a unique number, starting at 1000.
        
        protected Animal(string givenId)
        {
            Id = $"A{lastAssignedIdNumber++}"; // Uniqueness is guaranteed by this line
            // TODO: Fungerar numreringen? Stegas lastAssignedIdNumber bara när Animal skapas?
            this.givenId = givenId;
        }

        public virtual string Virtuell()
        {
            return "Animal";
        }

        public abstract string Abstrakt();

        /// <summary>
        /// Strings used to fill a row in a ListView.
        /// </summary>
        public string[] RowStrings => new string[] 
        {
            // TODO: Fyll på med lämpliga properties för formuläret
            // TODO: ID, Name (nick?), age, gender, special characteristics
            givenId,
            Id,
            NickName
        };

    }
}
