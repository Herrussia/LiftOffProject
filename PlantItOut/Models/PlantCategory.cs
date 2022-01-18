using System.Collections.Generic;

namespace PlantItOut.Models
{
    public class PlantCategory
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List <Plant> Plants { get; set; }

        public PlantCategory(string name)
        {
            Name = name;
        }

        public PlantCategory()
        {
        }
    }
}
