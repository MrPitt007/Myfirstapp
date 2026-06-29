using Microsoft.AspNetCore.Mvc.RazorPages;
using Myfirstapp.Models;

namespace Myfirstapp.Pages
{
    public class PeopleModel : PageModel
    {
        public List<Person> PeopleList { get; set; }

        public void OnGet()
        {
            PeopleList = new List<Person>
            {
                new Person { Id = 1, Name = "Anna", Email = "anna@email.com", PhoneNumber = "070-1234567" },
                new Person { Id = 2, Name = "Johan", Email = "johan@email.com", PhoneNumber = "070-9876543" },
                new Person { Id = 3, Name = "Maria", Email = "maria@email.com", PhoneNumber = "070-5556677" }
            };
        }
    }
}