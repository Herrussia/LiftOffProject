using System;
using System.Collections.Generic;

namespace PlantItOut.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PlantTag> PlantTags { get; set; }
        public PlantCategory Category { get; set; }
        public string ImageLink { get; set; }
        public int CategoryId { get; set; }
        //public List<Comment> Comments { get; set; }

        public Plant()
        {
        }

        public Plant(string name, string description, string imageLink)
        {
            Name = name;
            Description = description;
            ImageLink = imageLink;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Plant @plant &&
                Id == @plant.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
