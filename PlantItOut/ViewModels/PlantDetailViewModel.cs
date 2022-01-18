using PlantItOut.Models;
using System.Collections.Generic;

namespace PlantItOut.ViewModels
{
    public class PlantDetailViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string TagText { get; set; }
        public int PlantId { get; set;}

    public PlantDetailViewModel(Plant thePlant, List<PlantTag> plantTags)
    {
        PlantId = thePlant.Id;
        Name = thePlant.Name;
        Description = thePlant.Description;
        Category = thePlant.Category.Name;


        TagText = "";

        for (var i = 0; i < plantTags.Count; i++)
        {
            TagText += plantTags[i].Tag.Name;
            if (i < plantTags.Count - 1)
            {
                TagText += ", ";
            }
        }
    }
    }
}
