using System.Collections.Generic;

namespace SchoolJournal.Models
{
    public class Journal
    {
        
        private readonly List<Pupil> _pupils;

        public Journal(int id, string className, AcademicYear year)
        {
            Id = id;
            ClassName = className;
            Year = year;

            _pupils = new List<Pupil>();
        }

        public int Id { get; }


        /// <summary>
        /// Gets the name of the class.
        /// </summary>
        public string ClassName { get; }

        /// <summary>
        /// Gets academic year for the journal.
        /// </summary>
        public AcademicYear Year { get; }

        /// <summary>
        /// Gets class pupils.
        /// </summary>
        public IReadOnlyList<Pupil> Pupils
        {
            get { return _pupils; }
        }

        /// <summary>
        /// Adds a pupil to the journal.
        /// </summary>
        /// <param name="pupil"></param>
        public void AddPupil(Pupil pupil)
        {
            _pupils.Add(pupil);
        }
    }
}
