    public class User
    {
        public User(string firstName, string lastName, DateTime birthdate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthdate;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public DateTime Birthdate { get; }
    }
