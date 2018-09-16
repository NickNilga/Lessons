using System;
using System.Collections.Generic;

namespace SchoolJournal.Models
{
    public class Journal
    {


        private readonly List<Pupil> _pupils;

        public Journal(int id, string className, int startYear, int endYear)
        {
            Id = id;
            ClassName = className;
            StartYear = startYear;
            EndYear = endYear;

            _pupils = new List<Pupil>();
        }

        public int Id { get; }


        /// <summary>
        /// Gets the name of the class.
        /// </summary>
        public string ClassName { get; }

        public int StartYear { get; }

        public int EndYear { get; }

        /// <summary>
        /// Gets year, i.e. "2000/2001"
        /// </summary>
        public string AcademicYear
        {
            get { return StartYear + "/" + EndYear; }
        }

        /// <summary>
        /// Gets class pupils.
        /// </summary>
        public IReadOnlyList<Pupil> Pupils
        {
            get { return _pupils; }
        }

        public void AddPupil(Pupil pupil)
        {
            _pupils.Add(pupil);
        }
    }
}
