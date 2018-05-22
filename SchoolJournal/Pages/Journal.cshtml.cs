using System;
using SchoolJournal.Models;
using SchoolJournal.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace SchoolJournal.Pages
{
    public class JournalModel : PageModel
    {
        private readonly InMemoryRepository _repository;

        public JournalModel()
        {
            _repository = new InMemoryRepository();
        }

        public Journal Journal { get; set; }

        public string Title => Journal.ClassName + " " + Journal.AcademicYear;

        public IActionResult OnGet(int joirnalid)
        {
            Journal = _repository.GetJournal(joirnalid);

            return Page();
        }
    }
}
