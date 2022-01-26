using PlantItOut.Models;
using System.Collections.Generic;

namespace PlantItOut.ViewModels
{
    public class ResultsViewModel
    {
        public List<Plant> PlantResults { get; set; }
        public List<PlantCategory> PlantCategories { get; set; }

        public ResultsViewModel(List<Plant> plants, List<PlantCategory> plantCategories)
        {
            PlantResults = plants;
            PlantCategories = plantCategories;
        }
    }
}
