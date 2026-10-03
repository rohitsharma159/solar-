using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace SolarEnergy.Pages.Auth {
    public class LoginModel : PageModel {
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public void OnGet() { }

        public IActionResult OnPost() {
            // Hardcoded Admin Login Check
            if (Email == "admin@solareco.com" && Password == "admin123") {
                HttpContext.Session.SetString("UserRole", "Admin");
                HttpContext.Session.SetString("UserName", "Administrator");
                return RedirectToPage("/Admin/Index");
            }

            // Check in standard DataStore users
            var user = Models.DataStore.Users.FirstOrDefault(u => u.Email == Email && u.Password == Password);
            if (user != null) {
                HttpContext.Session.SetString("UserRole", "User");
                HttpContext.Session.SetString("UserName", user.Name);
                return RedirectToPage("/Index");
            }

            TempData["AuthMsg"] = "Invalid Email ya Password! Kripya dobara try karein (Admin: admin@solareco.com / admin123).";
            return Page();
        }
    }
}
