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
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }

        /*[Required(ErrorMessage = "Category Required")]*/
        public int CategoryId { get; set; }
        public List<SelectListItem> PlantCategories { get; set; }
        public AddPlantViewModel(List<PlantCategory> categories)
        {
            PlantCategories = new List<SelectListItem>();

            foreach (var category in categories)
            {
                PlantCategories.Add(new SelectListItem
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
