using AmazonDealsSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AmazonDealsSite.Pages
{
    public class ProductsModel : PageModel
    {
        public List<Deal> AllDeals { get; set; }

            public void OnGet()
            {
                AllDeals = new List<Deal>
                {
                    new Deal
                    {
                        Title = "Wireless Gaming Mouse",
                        Description = "High DPI RGB mouse with adjustable weights.",
                        ImageUrl = "https://placehold.co/400x300",
                        Promo = "1S2E3F4G5R",
                        Link = "https://amazon.com/dp/EXAMPLE1"
                    },
                    new Deal
                    {
                        Title = "Mechanical Keyboard",
                        Description = "Tactile switches with RGB backlight.",
                        ImageUrl = "https://placehold.co/400x300",
                        Promo = "1S2E3F4G5R",
                        Link = "https://amazon.com/dp/EXAMPLE2"
                    },
                    new Deal
                    {
                        Title = "Gaming Headset",
                        Description = "Surround sound with noise-canceling mic.",
                        ImageUrl = "https://placehold.co/400x300",
                        Promo = "1S2E3F4G5R",
                        Link = "https://amazon.com/dp/EXAMPLE3"
                    }
                };
            }

    }

}
