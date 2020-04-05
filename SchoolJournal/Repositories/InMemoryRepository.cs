using System;
using System.Collections.Generic;
using System.Linq;

using SchoolJournal.Models;

namespace SchoolJournal.Repositories
{
    /// <summary>
    /// Provides data from memory.
    /// </summary>
    public class InMemoryRepository
    {
        /// <summary>
        /// The journals.
        /// </summary>
        private readonly List<Journal> _journals;

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryRepository"/> 
        /// by creating a list of journals.
        /// </summary>
        public InMemoryRepository()
        {
            _journals = new List<Journal>();

            // Create journal for 8-А.
            Journal journal = new Journal(1, "8-А", new AcademicYear(2018));

            journal.AddPupil(new Pupil(1, "Никита", "Васильченко", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil(2, "Алексей", "Нильга", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil(3, "Максим", "Пташник", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil(4, "Михаил", "Нильга", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil(5, "Олег", "Кузьмин", new DateTime(2003, 1, 8)));

            // Add journal to the list of school journals.
            _journals.Add(journal);


            journal = new Journal(2, "8-Б", new AcademicYear(2018));
            journal.AddPupil(new Pupil(6, "Вася", "Тазиков", new DateTime(2003, 1, 8)));
            _journals.Add(journal);

            // Add a few empty journals.
            _journals.Add(new Journal(3, "8-В",  new AcademicYear(2018)));
            _journals.Add(new Journal(4, "8-Г", new AcademicYear(2018)));
            _journals.Add(new Journal(5, "8-Д", new AcademicYear(2017)));

        }

        /// <summary>
        /// Lists the journals.
        /// </summary>
        /// <returns>The list of journals.</returns>
        public IReadOnlyCollection<Journal> ListJournals()
        {
            return _journals;
        }

        /// <summary>
        /// Gets journal by id.
        /// </summary>
        /// <returns>The journal.</returns>
        /// <param name="id">Journal identifier.</param>
        public Journal GetJournal(int id)
        {
            return _journals.FirstOrDefault(journal => journal.Id == id);
        }

    }
}