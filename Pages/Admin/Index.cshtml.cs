using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace SolarEnergy.Pages.Admin {
    public class IndexModel : PageModel {
        [BindProperty(SupportsGet = true)]
        public int? editId { get; set; }
        public Models.Product EditProduct { get; set; }

        public IActionResult OnGet() {
            string userRole = HttpContext.Session.GetString("UserRole");
            
            // Check if user is logged in as Admin
            if (userRole != "Admin") {
                TempData["AuthMsg"] = "Kripya admin credentials (admin@solareco.com / admin123) ke sath login karein.";
                return RedirectToPage("/Auth/Login");
            }

            if (editId.HasValue) {
                EditProduct = SolarEnergy.Models.DataStore.Products.FirstOrDefault(p => p.Id == editId.Value);
            }
            return Page();
        }

        public IActionResult OnPostSaveProduct(int? Id, string Name, string Category, decimal Price, string ImageUrl, string Description) {
            if (HttpContext.Session.GetString("UserRole") != "Admin") return RedirectToPage("/Auth/Login");
            if (string.IsNullOrEmpty(ImageUrl)) ImageUrl = "https://images.unsplash.com/photo-1509391365360-e835f377c86a?w=500";

            if (Id.HasValue && Id.Value > 0) {
                var existing = SolarEnergy.Models.DataStore.Products.FirstOrDefault(p => p.Id == Id.Value);
                if (existing != null) {
                    existing.Name = Name;
                    existing.Category = Category;
                    existing.Price = Price;
                    existing.ImageUrl = ImageUrl;
                    existing.Description = Description ?? "";
                    TempData["AdminMsg"] = "Product successfully update ho gaya hai!";
                }
            } else {
                int newId = SolarEnergy.Models.DataStore.Products.Count > 0 ? SolarEnergy.Models.DataStore.Products.Max(p => p.Id) + 1 : 1;
                SolarEnergy.Models.DataStore.Products.Add(new Models.Product {
                    Id = newId, Name = Name, Category = Category, Price = Price, ImageUrl = ImageUrl, Description = Description ?? ""
                });
                TempData["AdminMsg"] = "Product successfully add ho gaya hai!";
            }
            return RedirectToPage();
        }

        public IActionResult OnPostDeleteProduct(int Id) {
            if (HttpContext.Session.GetString("UserRole") != "Admin") return RedirectToPage("/Auth/Login");
            var item = SolarEnergy.Models.DataStore.Products.FirstOrDefault(p => p.Id == Id);
            if (item != null) SolarEnergy.Models.DataStore.Products.Remove(item);
            TempData["AdminMsg"] = "Product successfully delete kar diya gaya hai!";
            return RedirectToPage();
        }
    }
}
