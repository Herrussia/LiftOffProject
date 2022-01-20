using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlantItOut.Data;
using PlantItOut.Models;
using PlantItOut.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PlantItOut.Controllers
{
    /*[Authorize]*/
    public class PlantCategoryController : Controller
    {
        private PlantDbContext context;

        public PlantCategoryController(PlantDbContext dbContext)
        {
            context = dbContext;
        }

        //GET
        public IActionResult Index()
        {
            List<PlantCategory> plantCategories = context.PlantCategories.ToList();
            return View(plantCategories);
        }

        [HttpGet]
        /*[Authorize(Roles = "Admin")]*/
        public IActionResult Create()
        {
            AddPlantCategoryViewModel addPlantCategoryViewModel = new AddPlantCategoryViewModel();
            return View(addPlantCategoryViewModel);
        }

        [HttpPost]
        /*[Authorize(Roles = "Admin")]*/
        public IActionResult ProcessCreatePlantCategoryForm(AddPlantCategoryViewModel addPlantCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                PlantCategory plantCategory = new PlantCategory()
                {
                    Name = addPlantCategoryViewModel.Name,
                };
                context.PlantCategories.Add(plantCategory);
                context.SaveChanges();

                return Redirect("/PlantCategory");
            }
            return View("Create", addPlantCategoryViewModel);
        }
    }
}
