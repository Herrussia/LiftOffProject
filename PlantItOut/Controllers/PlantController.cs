using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlantItOut.Data;
using PlantItOut.Models;
using PlantItOut.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PlantItOut.Controllers
{
    public class PlantController : Controller
    {
        private PlantDbContext context;

        public PlantController(PlantDbContext dbContext)
        {
            context = dbContext;
        }

        //GET 
        public IActionResult Index()
        {
            List<Plant> plants = context.Plants
                .Include(p => p.Category)
                .ToList();

            return View(plants);
        }

        public IActionResult Add()
        {
            List<PlantCategory> plants = context.PlantCategories.ToList();
            AddPlantViewModel addPlantViewModel = new AddPlantViewModel(plants);

            return View(addPlantViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddPlantViewModel addPlantViewModel)
        {
            if (!ModelState.IsValid)
            {
                PlantCategory theCategory = context.PlantCategories.Find(addPlantViewModel.CategoryId);
                Plant newPlant = new Plant
                {
                    Name = addPlantViewModel.Name,
                    Description = addPlantViewModel.Description,
                    ImageLink = addPlantViewModel.ImageLink,
                    Category = theCategory
                };
                context.Plants.Add(newPlant);
                context.SaveChanges();

            return Redirect("/Plant");
            }

            return View(addPlantViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.plants = context.Plants.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] plantIds)
        {
            foreach (int plantId in plantIds)
            {
                Plant plant = context.Plants.Find(plantId);
                context.Plants.Remove(plant);
            }
            context.SaveChanges();
            return Redirect("/Plant");
        }

        public IActionResult Detail(int id)
        {
            Plant plant = context.Plants
                .Include(p => p.Category)
                .Single(p => p.Id == id);

            List<PlantTag> plantTags = context.PlantTags
                .Where(pt => pt.PlantId == id)
                .Include(PlantTag => PlantTag.Tag)
                .ToList();

            PlantDetailViewModel plantViewModel = new PlantDetailViewModel(plant, plantTags);
            return View(plantViewModel);
        }
    }
}
