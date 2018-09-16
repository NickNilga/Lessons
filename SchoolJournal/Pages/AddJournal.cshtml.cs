using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SchoolJournal.Repositories;

namespace SchoolJournal.Pages
{
    public class AddJournalModel : PageModel
    {
        private readonly InMemoryRepository _repository;

        public AddJournalModel()
        {
            _repository = new InMemoryRepository();
        }

        public string Title => "Add New Journal";

        public string Description => "Please specify journal details and click Save.";


        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
