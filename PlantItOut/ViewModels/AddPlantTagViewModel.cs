using Microsoft.AspNetCore.Mvc.Rendering;
using PlantItOut.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlantItOut.ViewModels
{
    public class AddPlantTagViewModel
    {
        [Required(ErrorMessage = "Plant is required")]
        public int PlantId { get; set; }

        [Required(ErrorMessage = "Tag is required")]
        public int TagId { get; set; }
        public Plant Plant { get; set; }
        public List<SelectListItem> Tags { get; set; }

        public AddPlantTagViewModel(Plant theplant, List<Tag> plantTags)
        {
            Tags = new List<SelectListItem>();

            foreach (var tag in plantTags)
            {
                Tags.Add(new SelectListItem
                {
                    Value = tag.Id.ToString(),
                    Text = tag.Name,
                });
            }
            Plant = theplant;
        }

        public AddPlantTagViewModel()
        {
        }

    }
}
