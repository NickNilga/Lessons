using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SchoolJournal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SchoolJournal.Repositories;

namespace SchoolJournal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly InMemoryRepository _repository;

        public IndexModel()
        {
            _repository = new InMemoryRepository();
        }

        public string Title => "School 122";

        public string Description => "To see the list of pupils and their marks choose a journal from the list below.";

        public IReadOnlyCollection<Journal> Journals { get; set; }

        public IActionResult OnGet()
        {
            Journals = _repository.ListJournals();

            return Page();
        }
    }
}
