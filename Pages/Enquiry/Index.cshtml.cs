using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace SolarEnergy.Pages.Enquiry {
    public class IndexModel : PageModel {
        public void OnGet() { }
        public IActionResult OnPost(string Name, string Phone, string Email, string RequirementType, string Message) {
            TempData["EnqMsg"] = "Thank you! Your enquiry has been submitted successfully. Our team will contact you soon.";
            return RedirectToPage();
        }
    }
}
