using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace SolarEnergy.Pages.Products {
    public class IndexModel : PageModel {
        public void OnGet() { }
        public IActionResult OnPostEnquire(string ProductName, string CustName, string Contact, string Message) {
            TempData["Success"] = $"Enquiry for {ProductName} submitted successfully!";
            return RedirectToPage();
        }
    }
}
