using Microsoft.AspNetCore.Mvc;
using Online_Mobile_Shopping_Project.Models;
using Online_Mobile_Shopping_Project.ViewModel;

namespace Online_Mobile_Shopping_Project.Controllers
{
    public class UserController : Controller
    {
        MyDbContext DbContext;
        public UserController(MyDbContext dbContext)
        {
            this.DbContext = dbContext;
        }
        public IActionResult Profile()
        {
            int? Userid = HttpContext.Session.GetInt32("Userid");
            if (Userid == null)
            {
                return RedirectToAction("Login");
            }
            User CurrentUser = DbContext.Users.FirstOrDefault(u => u.id == Userid);
            return View(CurrentUser);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();  
        }
        [HttpPost]  
        public IActionResult Register(User user)
        {
            if(user == null)
            {
                return View("MyError");
            }
            DbContext.Users.Add(user);
            DbContext.SaveChanges();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            LoginVM loginVM = new LoginVM();
            return View(loginVM);
        }
        [HttpPost]
        public IActionResult Login(LoginVM login)
        {
            User user = DbContext.Users.FirstOrDefault(u => u.email == login.email && u.password == login.password);
            if(user == null)
            {
                LoginVM loginVM = new LoginVM();
                loginVM.message = "Wrong Email or Password";
                return View("Login", login);
            }
            HttpContext.Session.SetInt32("Userid",user.id );
            //return Content("Hi");
            return RedirectToAction("Profile");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
