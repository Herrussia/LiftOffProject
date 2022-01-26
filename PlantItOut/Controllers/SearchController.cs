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
    [Authorize]
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

        [HttpPost]
        public IActionResult Results(string searchTerm, string[] selectedTags)
        {
            List<Plant> plants = context.Plants.ToList();
            List<Plant> plantResults = new List<Plant>();
            List<PlantDetailViewModel> displayPlants = new List<PlantDetailViewModel>();
            List<PlantCategory> plantCategories = new List<PlantCategory>();
            

            /*if (searchTerm != null)
            {
                foreach (Plant plant in plants)
                {
                    if (plant.Name == searchTerm)
                    {
                        plantResults.Add(plant);
                    }
                }
            }*/
            if (selectedTags != null)
            {
                foreach (string tag in selectedTags)
                {
                    List<PlantTag> plantTags = context.PlantTags
                        .Where(pt => pt.TagId == int.Parse(tag))
                        .ToList();

                    foreach (PlantTag plantTag in plantTags)
                    {
                        List<Plant> results = context.Plants
                            .Where(p => p.Id == plantTag.PlantId)
                            .ToList();
                        foreach (Plant plant in results)
                        {
                            if (!plantResults.Contains(plant)){
                                plantResults.Add(plant);
                            }
                        }
                    }
                }
            }
            foreach (Plant plant in plantResults)
            {
                plantCategories = context.PlantCategories
                    .Where(pc => pc.Id == plant.CategoryId)
                    .ToList();
            }

            ResultsViewModel viewModel = new ResultsViewModel(plantResults, plantCategories);
            return View("Results", viewModel);
        }
    }
}

