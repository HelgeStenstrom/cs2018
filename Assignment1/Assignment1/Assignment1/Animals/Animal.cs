using Assignment1.Animals;

namespace Assignment1
{
    public abstract class Animal
    {
        // TODO: data as per 3.5
        private int age;
        private Gender gender;
        private string nickName;
        private int id;

        private static int lastAssignedIdNumber = 1000; // We give each individual animal a unique number, starting at 1000.

        public virtual string Virtuell()
        {
            return "Animal";
        }

        public abstract string Abstrakt();

        /// <summary>
        /// Strings used to fill a row in a ListView.
        /// </summary>
        public string[] RowStrings => new string[] {
            // TODO: Fyll på med lämpliga properties för formuläret
            // TODO: ID, Name (nick?), age, gender, special characteristics
                    nickName
                    };

    }
}
