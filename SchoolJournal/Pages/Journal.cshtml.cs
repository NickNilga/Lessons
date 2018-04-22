using System;
using SchoolJournal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace SchoolJournal.Pages
{
    public class ClassModel : PageModel
    {
        public Class Class { get; set; }

        public IActionResult OnGet()
        {
            Class c = new Class("8-A");

            c.AddPupil(new Pupil("Alexei", "Nilga", new DateTime(2003, 12, 9)));
            c.AddPupil(new Pupil("Michael", "Nilga", new DateTime(2004, 5, 14)));
            c.AddPupil(new Pupil("Maxim", "Ptashnik", new DateTime(2004, 9, 20)));
            c.AddPupil(new Pupil("Oleg", "Kyzmin", new DateTime(2003, 9, 28)));
            c.AddPupil(new Pupil("Daniil", "Dobronos", new DateTime(2004, 6, 15)));

            Class = c;

            return Page();
        }
    }
}
