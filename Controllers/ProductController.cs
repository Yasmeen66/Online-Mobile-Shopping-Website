using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Online_Mobile_Shopping_Project.Models;

namespace Online_Mobile_Shopping_Project.Controllers
{
    public class ProductController : Controller
    {
        MyDbContext dbContext;
        public ProductController(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        public IActionResult Index()
        {
            List<Product> products = dbContext.Products.ToList();
            return View(products);
        }
        public IActionResult Details(int id)
        {
            Product product = dbContext.Products.SingleOrDefault(p => p.id == id);
            return View(product);
        }
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product, IFormFile Img)
        {
            string path = $"wwwroot/Images/{Img.FileName}";

            FileStream fs = new FileStream(path, FileMode.Create);

            Img.CopyTo(fs);

            product.img = $"/Images/{Img.FileName}";

            dbContext.Products.Add(product);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

       
    }
}
    

