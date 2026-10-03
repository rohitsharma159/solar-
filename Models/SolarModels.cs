using System.Collections.Generic;

namespace SolarEnergy.Models {
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Category { get; set; } = "";
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = "";
        public string Description { get; set; } = "";
    }

    public class User {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string Role { get; set; } = "User";
    }

    public class Enquiry {
        public int Id { get; set; }
        public string CustomerName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Message { get; set; } = "";
    }

    public class Feedback {
        public int Id { get; set; }
        public string CustomerName { get; set; } = "";
        public string Comments { get; set; } = "";
        public int Rating { get; set; }
    }

    public static class DataStore {
        public static List<Product> Products { get; set; } = new List<Product> {
            new Product { Id = 1, Name = "Monocrystalline Solar Panel 500W", Category = "Solar Panels", Price = 14999, ImageUrl = "https://images.unsplash.com/photo-1509391365360-e835f377c86a?w=500&auto=format&fit=crop&q=80", Description = "High efficiency 21%+ mono perc solar panel with 25 years warranty." },
            new Product { Id = 2, Name = "Hybrid Solar Inverter 5kVA", Category = "Inverters", Price = 45000, ImageUrl = "https://images.unsplash.com/photo-1473341304170-971dccb5ac1e?w=500&auto=format&fit=crop&q=80", Description = "Pure sine wave hybrid inverter with smart LCD display and grid-tie support." },
            new Product { Id = 3, Name = "Lithium Iron Phosphate Battery 48V", Category = "Batteries", Price = 75000, ImageUrl = "https://images.unsplash.com/photo-1558449041-62194096d30d?w=500&auto=format&fit=crop&q=80", Description = "Long-lasting LiFePO4 battery pack with 4000+ life cycles and BMS protection." },
            new Product { Id = 4, Name = "Tubular Solar Battery 150Ah", Category = "Batteries", Price = 15500, ImageUrl = "https://images.unsplash.com/photo-1617788138017-80ad40651399?w=500&auto=format&fit=crop&q=80", Description = "Deep discharge heavy duty tubular battery ideal for solar power backup." },
            new Product { Id = 5, Name = "Polycrystalline Solar Panel 330W", Category = "Solar Panels", Price = 9500, ImageUrl = "https://images.unsplash.com/photo-1508873535684-277a3cbcc4e8?w=500&auto=format&fit=crop&q=80", Description = "Cost-effective poly solar panel for residential and commercial rooftops." },
            new Product { Id = 6, Name = "Solar Street Light 90W LED", Category = "Lighting", Price = 4200, ImageUrl = "https://images.unsplash.com/photo-1513836279014-a89f7a76ae86?w=500&auto=format&fit=crop&q=80", Description = "All-in-one automatic dusk-to-dawn outdoor solar street lighting system." },
            new Product { Id = 7, Name = "Solar Water Heater 200L", Category = "Accessories", Price = 26000, ImageUrl = "https://images.unsplash.com/photo-1592833159155-c62df1b65634?w=500&auto=format&fit=crop&q=80", Description = "Evacuated tube collector based solar water heater for domestic hot water." },
            new Product { Id = 8, Name = "MPPT Solar Charge Controller 60A", Category = "Accessories", Price = 6500, ImageUrl = "https://images.unsplash.com/photo-1558449041-62194096d30d?w=500&auto=format&fit=crop&q=80", Description = "High efficiency maximum power point tracking solar charge controller." },
            new Product { Id = 9, Name = "Monocrystalline Solar Panel 550W", Category = "Solar Panels", Price = 16500, ImageUrl = "https://images.unsplash.com/photo-1509391365360-e835f377c86a?w=500&auto=format&fit=crop&q=80", Description = "Ultra-high power output bifacial monocrystalline panel for large installations." },
            new Product { Id = 10, Name = "Solar Submersible Water Pump 2HP", Category = "Pumps", Price = 48000, ImageUrl = "https://images.unsplash.com/photo-15743594115f9-39908cf9241b?w=500&auto=format&fit=crop&q=80", Description = "Heavy duty solar pump system ideal for agricultural irrigation and borewells." },
            new Product { Id = 11, Name = "Solar Garden Light LED (Pack of 4)", Category = "Lighting", Price = 1999, ImageUrl = "https://images.unsplash.com/photo-1513836279014-a89f7a76ae86?w=500&auto=format&fit=crop&q=80", Description = "Decorative automatic waterproof outdoor solar lights for lawns and pathways." },
            new Product { Id = 12, Name = "Heavy Duty Hybrid Inverter 10kW", Category = "Inverters", Price = 85000, ImageUrl = "https://images.unsplash.com/photo-1473341304170-971dccb5ac1e?w=500&auto=format&fit=crop&q=80", Description = "Commercial grade three-phase hybrid inverter with advanced load management." },
            new Product { Id = 13, Name = "Bifacial Solar Panel 540W", Category = "Solar Panels", Price = 17500, ImageUrl = "https://images.unsplash.com/photo-1509391365360-e835f377c86a?w=500&auto=format&fit=crop&q=80", Description = "Double glass bifacial panel generating power from both front and rear sides." },
            new Product { Id = 14, Name = "Grid-Tie Solar Inverter 3kW", Category = "Inverters", Price = 28000, ImageUrl = "https://images.unsplash.com/photo-1473341304170-971dccb5ac1e?w=500&auto=format&fit=crop&q=80", Description = "Compact transformerless grid-tie inverter designed for residential net metering." },
            new Product { Id = 15, Name = "Solar Home Lighting System with Radio", Category = "Lighting", Price = 3499, ImageUrl = "https://images.unsplash.com/photo-1513836279014-a89f7a76ae86?w=500&auto=format&fit=crop&q=80", Description = "Portable solar lighting kit with multiple LED bulbs, USB phone charging, and FM radio." },
            new Product { Id = 16, Name = "PWM Solar Charge Controller 30A", Category = "Accessories", Price = 1800, ImageUrl = "https://images.unsplash.com/photo-1558449041-62194096d30d?w=500&auto=format&fit=crop&q=80", Description = "Reliable pulse width modulation charge controller with LCD display and USB ports." },
            new Product { Id = 17, Name = "Portable Solar Generator 1000Wh", Category = "Batteries", Price = 62000, ImageUrl = "https://images.unsplash.com/photo-1558449041-62194096d30d?w=500&auto=format&fit=crop&q=80", Description = "All-in-one portable power station with AC outlets and solar charging compatibility." },
            new Product { Id = 18, Name = "Solar Fence Energizer", Category = "Accessories", Price = 8999, ImageUrl = "https://images.unsplash.com/photo-1509391365360-e835f377c86a?w=500&auto=format&fit=crop&q=80", Description = "High-voltage solar powered electric fence controller for farm and crop protection." },
            new Product { Id = 19, Name = "Rooftop Solar Mounting Structure (1kW)", Category = "Accessories", Price = 4500, ImageUrl = "https://images.unsplash.com/photo-1508873535684-277a3cbcc4e8?w=500&auto=format&fit=crop&q=80", Description = "Hot-dip galvanized heavy-duty mounting rails and clamps for rooftop solar panels." },
            new Product { Id = 20, Name = "Solar Attic Fan / Ventilation Fan", Category = "Accessories", Price = 5500, ImageUrl = "https://images.unsplash.com/photo-1509391365360-e835f377c86a?w=500&auto=format&fit=crop&q=80", Description = "Eco-friendly roof ventilation fan powered directly by solar panel to cool indoor spaces." }
        };

        public static List<User> Users { get; set; } = new List<User> {
            new User { Id = 1, Name = "Rahul Sharma", Email = "rahul@solareco.com", Password = "password123", Role = "User" },
            new User { Id = 2, Name = "Aman Verma", Email = "aman@solareco.com", Password = "password123", Role = "User" }
        };

        public static List<Enquiry> Enquiries { get; set; } = new List<Enquiry> {
            new Enquiry { Id = 1, CustomerName = "Vikas Kumar", Email = "vikas@gmail.com", Phone = "9876543210", Message = "Need quotation for 3kW rooftop solar system." }
        };

        public static List<Feedback> Feedbacks { get; set; } = new List<Feedback> {
            new Feedback { Id = 1, CustomerName = "Rohan Gupta", Comments = "Excellent service and high quality solar panels!", Rating = 5 }
        };
    }
}
