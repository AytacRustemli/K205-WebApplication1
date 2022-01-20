using K205_WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace K205_WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        List<Product> products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Asus AU X415FA-1GEB",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                Photourl = "https://kontakt.az/wp-content/uploads/2022/01/New-Project-1-68.png",
                Price = "999.99 AZN",
                Color = "Rengi: Gümüşü",
                Ceki = "Cekisi: 1.6 kq",
                Yaddas = "Operativ yaddas: 4 GB",
                Ekrandiaqanal = "Ekranin diaqanali: 14",
                Kateqoriya = "Kateqoriya: Ev və iş",
                Emeliyyatsistemi = "Emeliyyat sistemi: FreeDOS"
            }
        };
        public IActionResult Index()
        {
            ViewData["products"] = products;
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
