using System;

namespace SchoolJournal.Models
{
    public class Pupil : Person
    {
        public Pupil(int id, string firstName, string lastName, DateTime dateOfBirth)
            : base(id, firstName, lastName)
        {
            BirthDate = dateOfBirth;
        }

        /// <summary>
        /// Gets pupil's date of birth.
        /// </summary>
        public DateTime BirthDate { get; }
    }   

}
