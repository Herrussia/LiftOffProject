using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlantItOut.Data;
using PlantItOut.Models;
using PlantItOut.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PlantItOut.Controllers
{
    /*[Authorize]*/
    public class PlantController : Controller
    {
        private PlantDbContext context;

        public PlantController(PlantDbContext dbContext)
        {
            context = dbContext;
        }

        //GET 
        /*[Authorize]*/
        public IActionResult Index()
        {
            List<Plant> plants = context.Plants.ToList();
            return View(plants);
        }

        /*[Authorize(Roles= "Admin")]*/
        public IActionResult Add()
        {
            List<PlantCategory> plants = context.PlantCategories.ToList();
            AddPlantViewModel addPlantViewModel = new AddPlantViewModel(plants);

            return View(addPlantViewModel);
        }

        [HttpPost]
        /*[Authorize(Roles = "Admin")]*/
        public IActionResult Add(AddPlantViewModel addPlantViewModel, string[] selectedTags)
        {
            if (ModelState.IsValid)
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

                foreach(string tag in selectedTags) 
                {
                    PlantTag plantTag = new PlantTag
                    {
                        Plant = newPlant,
                        PlantId = newPlant.Id,
                        TagId = int.Parse(tag),
                    };
                    context.PlantTags.Add(plantTag);
                }
                context.SaveChanges();
                return Redirect("/Plant");
            }

            return View(addPlantViewModel);
        }

        /*[Authorize(Roles = "Admin")]*/
        public IActionResult Delete()
        {
            ViewBag.plants = context.Plants.ToList();
            return View();
        }

        [HttpPost]
        /*[Authorize(Roles = "Admin")]*/
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

        /*[Authorize]*/
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
