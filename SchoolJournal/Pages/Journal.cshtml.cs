using System;
using SchoolJournal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace SchoolJournal.Pages
{
    public class JournalModel : PageModel
    {
        public Journal Journal { get; set; }

        public string Title => Journal.ClassName + " " + Journal.AcademicYear;

        public IActionResult OnGet()
        {
            Journal journal = new Journal("8-A", 2017, 2018);

            journal.AddPupil(new Pupil("Никита", "Васильченко", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil("Алексей", "Нильга", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil("Максим", "Пташник", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil("Михаил", "Нильга", new DateTime(2003, 1, 8)));
            journal.AddPupil(new Pupil("Олег", "Кузьмин", new DateTime(2003, 1, 8)));



            Journal = journal;

            return Page();
        }
    }
}
