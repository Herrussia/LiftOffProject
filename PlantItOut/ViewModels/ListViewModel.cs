using PlantItOut.Models;
using System.Collections.Generic;

namespace PlantItOut.ViewModels
{
    public class ListViewModel
    {
        public List<Plant> BeginnerResults { get; set; }
        public List<Plant> IntermediateResults { get; set; }
        public List<Plant> ExpertResults { get; set; }

        public ListViewModel(List<Plant> beginnerResults, List<Plant> intermediateResults, List<Plant> expertResults)
        {
            BeginnerResults = beginnerResults;
            IntermediateResults = intermediateResults;
            ExpertResults = expertResults;
        }
    }
}
