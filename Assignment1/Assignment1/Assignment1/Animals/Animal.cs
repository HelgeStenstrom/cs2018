namespace Assignment1
{
    public abstract class Animal
    {
        // TODO: data as per 3.5
        #region Fields
        private int Age { get; }
        private Gender Gender { get; }
        private string Name { get; }
        private string givenId; // It's the AnimalManager's responsibility to ensure this ID is unique.
        public string Id { get; } 
        private static int lastAssignedIdNumber = 1000; // We give each individual animal a unique number, starting at 1000.
        private string _species = "Animal";
        #endregion

        #region Properties

        /// <summary>
        /// The last assigned ID number can be used to make assumptions about what the next assigned number will be.
        /// </summary>
        public static int LastAssignedIdNumber
        {
            get => lastAssignedIdNumber;
        }

        /// <summary>
        /// Strings used to fill a row in a ListView.
        /// </summary>
        public string[] RowStrings => new string[] 
        {
            // TODO: Fyll på med lämpliga properties för formuläret
            // TODO: ID, Name (nick?), age, gender, special characteristics
            givenId,
            Id,
            Name,
            Age.ToString(),
            Gender.ToString(),
            this.GetType().Name,       
            this.ToString()
        };

        #endregion

        /// <summary>
        /// Constructor for an animal, called by subclasses.
        /// The Animal class will itself maintain a unique ID string, 
        /// in addition to the one given by the AnimalManager.
        /// </summary>
        /// <param name="givenId">It's the caller's responsibility that this value is unique.</param>
        /// <param name="name">The name of the animal, free format.</param>
        /// <param name="gender">The gender of the animal</param>
        /// <param name="age">The age of the animal, in whole years.</param>
        protected Animal(string givenId, string name, Gender gender, int age)
        {
            Id = $"B{lastAssignedIdNumber++}"; // Uniqueness is guaranteed by this line
            this.givenId = givenId;
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }



        #region Methods
        // No methods defined.
        #endregion
    }
}
