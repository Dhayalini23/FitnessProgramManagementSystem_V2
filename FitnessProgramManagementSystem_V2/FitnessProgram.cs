using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V2
{
    internal class FitnessProgram
    {

        public string FitnessProgramId { get; set; }
        public string Title{ get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }

        public FitnessProgram(string fitnessProgramId, string title, string duration, decimal price)
        {
            FitnessProgramId = fitnessProgramId;
            Title = title;
            Duration = duration;
            Price = price;
        }

        //public override string ToString(string fitnessProgramId, string title, string duration, decimal price) 
        //{

        //    return $"fitnessProgramId: {FitnessProgramId}, Title: {Title}, Duration: {Duration}, Price: {Price}";
        //}
    }
}
