using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace SolarEnergy.Pages.Feedback {
    public class IndexModel : PageModel {
        public void OnGet() { }
        public IActionResult OnPost(string Name, int Rating, string Comment) {
            TempData["Msg"] = "Thank you for your valuable feedback!";
            return RedirectToPage();
        }
    }
}
