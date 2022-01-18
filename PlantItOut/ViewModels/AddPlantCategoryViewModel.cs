using System.ComponentModel.DataAnnotations;

namespace PlantItOut.ViewModels
{
    public class AddPlantCategoryViewModel
    {
        [Required(ErrorMessage = "Category Name Required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a valid Name")]
        public string Name { get; set; }
    }
}
