using System;
namespace SchoolJournal.Models
{
    public class Pupil : Person
    {
        public Pupil(string firstName, string lastName, DateTime dateOfBirth)
            : base(firstName, lastName)
        {
            BirthDate = dateOfBirth;
        }

        /// <summary>
        /// Gets pupil's date of birth.
        /// </summary>
        public DateTime BirthDate { get; }
    }

}
