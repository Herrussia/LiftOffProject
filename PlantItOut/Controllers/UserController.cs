using Microsoft.AspNetCore.Mvc;
using PlantItOut.Models;
using PlantItOut.ViewModels;

namespace PlantItOut.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User(
                    addUserViewModel.Username,
                    addUserViewModel.Password
                    );
                return View("Index", newUser);
            }
            return View("Add");
        }
    }
}
