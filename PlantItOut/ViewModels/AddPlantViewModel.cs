using System;
using PlantItOut.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PlantItOut.ViewModels
{
    public class AddPlantViewModel
    {
        public int PlantId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        
        public string Description { get; set; }

        [Required(ErrorMessage = "Category Required")]
        public int CategoryId { get; set; }
        public List<SelectListItem> PlantCategories { get; set; }
        public AddPlantViewModel(List<PlantCategory> categories)
        {
            PlantCategories = new List<SelectListItem>();

            foreach(var category in categories)
            {
                PlantCategories.Add(
                    new SelectListItem
                    {
                        Value = category.Id.ToString(),
                        Text = category.Name,
                    });
            }
        }
        public AddPlantViewModel()
        {
        }
    }
}
