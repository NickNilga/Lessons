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

        public Journal Journal { get; private set; }

        public string Title => $"{Journal.ClassName} {Journal.Year.StartsAt}/{Journal.Year.EndsAt}";
        

        public IActionResult OnGet(int id)
        {
            Journal = _repository.GetJournal(id);

            return Page();
        }
    }
}
