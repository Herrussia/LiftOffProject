using PlantItOut.Models;
using System.Collections.Generic;

namespace PlantItOut.ViewModels
{
    public class SearchPlantViewModel
    {
        public int PlantId { get; set; }
        public string PlantName { get; set; }
        public List<Tag> Tags { get; set; }

        public SearchPlantViewModel(List<Tag> tags)
        {
            Tags = tags;
        }

        public SearchPlantViewModel()
        {
        }

    }
}
