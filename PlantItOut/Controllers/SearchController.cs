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
    public class SearchController : Controller
    {
        private PlantDbContext context;

        public SearchController(PlantDbContext dbContext)
        {
            context = dbContext;
        }

        //GET
        public IActionResult Index()
        {
            ViewBag.columns = ListController.ColumnChoices;
            return View();
        }

        public IActionResult Results(string searchType, string searchTerm)
        {
            List<Plant> plants;
            List<PlantDetailViewModel> displayPlants = new List<PlantDetailViewModel>();

            if (string.IsNullOrEmpty(searchTerm))
            {
                plants = context.Plants
                    .Include(p => p.Category)
                    .ToList();

                foreach (var plant in plants)
                {
                    List<PlantTag> plantTags = context.PlantTags
                        .Where(pt => pt.PlantId == plant.Id)
                        .Include(pt => pt.Tag)
                        .ToList();

                    PlantDetailViewModel newDisplayPlant = new PlantDetailViewModel(plant, plantTags);
                }
            }
            else
            {
                if (searchType == "light level")
                {
                    plants = context.Plants
                        .Include(p => p.Category)
                        .Where(p => p.Category.Name == searchTerm)
                        .ToList();

                    foreach(Plant plant in plants)
                    {
                        List<PlantTag> plantTags = context.PlantTags
                            .Where(pt => pt.PlantId == plant.Id)
                            .Include(pt => pt.Tag)
                            .ToList();

                        PlantDetailViewModel newDisplayPlant = new PlantDetailViewModel(plant, plantTags);
                        displayPlants.Add(newDisplayPlant);
                    }
                }
                else if (searchType == "water level")
                {
                    plants = context.Plants
                        .Include(p => p.Category)
                        .Where(p => p.Category.Name == searchTerm)
                        .ToList();

                    foreach (Plant plant in plants)
                    {
                        List<PlantTag> plantTags = context.PlantTags
                            .Where(pt => pt.PlantId == plant.Id)
                            .Include(pt => pt.Tag)
                            .ToList();

                        PlantDetailViewModel newDisplayPlant = new PlantDetailViewModel(plant, plantTags);
                        displayPlants.Add(newDisplayPlant);
                    }
                }
                else if (searchType == "skill level")
                {
                    plants = context.Plants
                        .Include(p => p.Category)
                        .Where(p => p.Category.Name == searchTerm)
                        .ToList();

                    foreach (Plant plant in plants)
                    {
                        List<PlantTag> plantTags = context.PlantTags
                            .Where(pt => pt.PlantId == plant.Id)
                            .Include(pt => pt.Tag)
                            .ToList();

                        PlantDetailViewModel newDisplayPlant = new PlantDetailViewModel(plant, plantTags);
                        displayPlants.Add(newDisplayPlant);
                    }
                }
            }
            ViewBag.columns = ListController.ColumnChoices;
            ViewBag.title = "Plants with " + ListController.ColumnChoices[searchType] + ": " + searchTerm;
            ViewBag.plants = displayPlants;

            return View("Index");
        }
    }
}
