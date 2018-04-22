using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SchoolJournal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SchoolJournal.Pages
{
    public class IndexModel : PageModel
    {
        public string Title => "School 122";

        public string Description => "To see the list of pupils and their marks choose a journal from the list below.";

        public IReadOnlyCollection<Journal> Journals { get; set; }

        public IActionResult OnGet()
        {
            // Создаем список журналов.
            List<Journal> journals = new List<Journal>();

            // Создаем журнал для 8-А.
            Journal journal = new Journal("8-А", 2017, 2018);
           
            // Добавляем журнал 8-А в список журналов школы.
            journals.Add(journal);

            // Добавляем в список журналов несколько пустых журналов.
            journals.Add(new Journal("8-Б", 2017, 2018));
            journals.Add(new Journal("8-В", 2017, 2018));
            journals.Add(new Journal("8-Г", 2017, 2018));
            journals.Add(new Journal("8-Д", 2017, 2018));

            // Инициализируем значение поля Journals, чтобы журналы были видны на странице.
            Journals = journals;

            return Page();
        }
    }
}
