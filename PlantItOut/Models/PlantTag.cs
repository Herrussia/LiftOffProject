﻿namespace PlantItOut.Models
{
    public class PlantTag
    {
        public int PlantId { get; set; }
        public Plant Plant { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public PlantTag()
        {
        }
    }
}
