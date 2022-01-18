using Microsoft.AspNetCore.Mvc;
using PlantItOut.Data;
using PlantItOut.Models;
using PlantItOut.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PlantItOut.Controllers
{
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
        public IActionResult Create()
        {
            AddPlantCategoryViewModel addPlantCategoryViewModel = new AddPlantCategoryViewModel();
            return View(addPlantCategoryViewModel);
        }

        [HttpPost]
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
