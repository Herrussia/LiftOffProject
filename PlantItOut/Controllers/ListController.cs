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
        private PlantDbContext context;

        public ListController(PlantDbContext dbContext)
        {
            context = dbContext;
        }

        internal static Dictionary<string, string> ColumnChoices = new Dictionary<string, string>()
        {
            {"all", "All"},
            {"beginner", "Beginner"},
            {"intermediate", "Intermediate"},
            {"expert", "Expert" }
        };

        internal static List<string> TableChoices = new List<string>()
        {
            "all, All",
            "beginner",
            "intermediate",
            "expert",
        };

        public IActionResult Index()
        {

            ViewBag.columns = ColumnChoices;
            ViewBag.tablechoices = TableChoices;
            ViewBag.plants = context.Plants.ToList();

            List<Plant> plants = context.Plants
                .Where(p => p.Category.Id == p.CategoryId)
                .ToList();

            List<Plant> beginnerResults = new List<Plant>();
            List<Plant> intermediateResults = new List<Plant>();
            List<Plant> expertResults = new List<Plant>();

            foreach (Plant plant in plants)
            {
                if (plant.CategoryId == 1)
                {
                    beginnerResults.Add(plant);
                }
                else if (plant.CategoryId == 2)
                {
                    intermediateResults.Add(plant);
                }
                else if (plant.CategoryId == 3)
                {
                    expertResults.Add(plant);
                }
                /*else if (plant.Category.Name == "all")
                {
                    List<Plant> plants = context.Plants.ToList();
                }*/
            }
            ListViewModel viewModel = new ListViewModel(beginnerResults, intermediateResults, expertResults);
        return View("Index", viewModel);
        }
    }
}
