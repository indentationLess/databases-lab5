using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab5.Pages.SurveyPage
{
    public class SurveyModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public int Stars { get; set; }

        [BindProperty]
        public string Review { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPostSubmit()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("./Result", new { name = Name, stars = Stars, review = Review });
        }
    }
}