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
        private List<Journal> _journals;

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryRepository"/> 
        /// by creating a list of journals.
        /// </summary>
        public InMemoryRepository()
        {
            _journals = new List<Journal>();

            // Создаем журнал для 8-А.
            Journal journal = new Journal(1, "8-А", 2017, 2018);

            journal.AddPupil(new Pupil("Никита", "Васильченко", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil("Алексей", "Нильга", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil("Максим", "Пташник", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil("Михаил", "Нильга", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil("Олег", "Кузьмин", new DateTime(2003, 1, 8)));

            // Добавляем журнал 8-А в список журналов школы.
            _journals.Add(journal);


            journal = new Journal(2, "8-Б", 2017, 2018);
            journal.AddPupil(new Pupil("Вася", "Тазиков", new DateTime(2003, 1, 8)));
            _journals.Add(journal);

            // Добавляем в список журналов несколько пустых журналов.
            _journals.Add(new Journal(3, "8-В", 2017, 2018));
            _journals.Add(new Journal(4, "8-Г", 2017, 2018));
            _journals.Add(new Journal(5, "8-Д", 2017, 2018));

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