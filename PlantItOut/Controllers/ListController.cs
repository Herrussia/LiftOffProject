using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlantItOut.Data;
using PlantItOut.Models;
using PlantItOut.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PlantItOut.Controllers
{
    public class ListController : Controller
    {
        internal static Dictionary<string, string> ColumnChoices = new Dictionary<string, string>()
        {
            {"all", "All"},
            {"light level", "Light Level"},
            {"water level", "Water Level"},
            {"skill level", "Skill Level" }
        };

        internal static List<string> TableChoices = new List<string>()
        {
            "light level",
            "water level",
            "skill level",
            
        };

        private PlantDbContext context;
        public ListController(PlantDbContext dbContext)
        {
            context = dbContext;
        }

        //GET
        public IActionResult Index()
        {
            ViewBag.columns = ColumnChoices;
            ViewBag.tablechoices = TableChoices;
            ViewBag.tags = context.Tags.ToList();
            return View();
        }

        //list plants by column and value
        public IActionResult Plants(string column, string value)
        {
            List<Plant> plants = new List<Plant>();
            List<PlantDetailViewModel> displayPlants = new List<PlantDetailViewModel>();

            if (column.ToLower().Equals("all"))
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
                displayPlants.Add(newDisplayPlant);
            }
                ViewBag.Title = "All Plants";
            }
            else
            {
                if (column == "light level")
                {
                    plants = context.Plants
                        .Include(p => p.Category)
                        .Where(p => p.Category.Name == value)
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
                else if (column == "water level")
                {
                    plants = context.Plants
                        .Include(p => p.Category)
                        .Where(p => p.Category.Name == value)
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
                else if (column == "skill level")
                {
                    plants = context.Plants
                        .Include(p => p.Category)
                        .Where(p => p.Category.Name == value)
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
                ViewBag.Title = "Plants with " + ColumnChoices[column] + ": " + value;
            }
            ViewBag.plants = displayPlants;
            return View();
        }
    }
}
