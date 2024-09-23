using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Mobile_Shopping_Project.Models;

namespace Online_Mobile_Shopping_Project.Controllers
{
    public class CartController : Controller
    {
        MyDbContext dbContext;
        public CartController(MyDbContext dbContext)
        {
            this.dbContext= dbContext;
        }
        public IActionResult AddCart()
        {
            return View();
        }
        public IActionResult Message()
        {
            return View();
        }
    }
}
