using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using RenoMate.Data;
using RenoMate.Models;

namespace RenoMate.Controllers
{
    public class UserController : Controller
    {

        private readonly DBContext dbContext;

        public UserController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }


        // Login action
        [HttpGet]
        public IActionResult Login()
        {
            var loginViewModel = new LoginViewModel();
            return View(loginViewModel);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginModel)
        {
           
            var user = dbContext.Users.SingleOrDefault(u => u.UserEmail == loginModel.UserEmail && u.UserPassword == loginModel.UserPassword);

            if(user == null)
            {
                return RedirectToAction("Login");
            }

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel addUserRequest)
        {
            var user = new User()
            {
                UserId = Guid.NewGuid(),
                UserName = addUserRequest.UserName,
                UserEmail = addUserRequest.UserEmail,
                UserPassword = addUserRequest.UserPassword,
                UserAddress = addUserRequest.UserAddress,
                UserPhone = addUserRequest.UserPhone
            };


            ////add the userid in session               
            //HttpContext.Session.SetString("UserId", user.UserId.ToString());

            //if (user.UserName != null)
            //{
            //    HttpContext.Session.SetString("UserName", user.UserName);
            //}

            //HttpContext.Session.SetString("UserEmail", user.UserEmail);


            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
