﻿using System.ComponentModel.DataAnnotations;

namespace PlantItOut.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Tag(string name)
        {
            Name = name;
        }

        public Tag()
        {
        }
    }
}
