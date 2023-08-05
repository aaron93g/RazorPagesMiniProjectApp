using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using PersonnelAppLibrary.Models;
using DemoLibrary;

namespace RazorPagesMiniProject.Pages
{
    public class PeopleModel : PageModel
    {
        [BindProperty]
        public PersonModel person { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
