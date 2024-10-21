using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab5.Pages.SurveyPage
{
	public class ResultModel : PageModel
	{
		public string Name { get; set; }
		public int Stars { get; set; }
		public string Review { get; set; }

		public void OnGet(string name, int stars, string review)
		{
			Name = name;
			Stars = stars;
			Review = review;
		}
	}
}