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
            List<Tag> tags = context.Tags.ToList();
            /*ViewBag.columns = ListController.ColumnChoices;*/
            SearchPlantViewModel viewModel = new SearchPlantViewModel(tags);
            return View(viewModel);
        }

        public IActionResult Results(string searchTerm, string[] selectedTags)
        {
            List<Plant> plants = context.Plants.ToList();
            List<Plant> plantResults = new List<Plant>();
            List<PlantDetailViewModel> displayPlants = new List<PlantDetailViewModel>();

            if (string.IsNullOrEmpty(searchTerm))
            {
                foreach (Plant plant in plants)
                {
                    if (plant.Name == searchTerm)
                    {
                        Plant results = plant;
                        plants.Add(results);
                    }
                }
            }
            else
            {
                foreach (string tag in selectedTags)
                {
                    List<PlantTag> tags = context.PlantTags
                        .Where(pt => pt.TagId == int.Parse(tag))
                        .ToList();

                    foreach (PlantTag plantTag in tags)
                    {
                        List<Plant> results = context.Plants
                            .Where(p => p.Id == plantTag.PlantId)
                            .ToList();
                        foreach (Plant plant in plantResults)
                        {
                            if (!plantResults.Contains(plant)){
                                plantResults.Add(plant);
                            }
                        }
                    }
                }
                ViewBag.columns = ListController.ColumnChoices;
                ViewBag.plants = displayPlants;
            }
            ResultsViewModel viewModel = new ResultsViewModel(plantResults);
            return View("Results", viewModel);
        }
    }
}

