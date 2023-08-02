using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonnelAppLibrary.Models;

namespace RazorPagesMiniProject.Pages
{
    public class PeopleModel : PageModel
    {
        [BindProperty]
        public PersonModel person { get; set; }

        public void OnGet()
        {
        }
    }
}
