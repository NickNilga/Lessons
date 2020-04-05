namespace SchoolJournal.Models
{
    /// <summary>
    /// Represents abstract person.
    /// </summary>
    public abstract class Person
    {
        
        protected Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Gets person unique ID.
        /// </summary>
        public int Id { get; }
        
        /// <summary>
        /// Gets person first (family) name.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Gets person last (given) name.
        /// </summary>
        public string LastName { get; }
    }
}
