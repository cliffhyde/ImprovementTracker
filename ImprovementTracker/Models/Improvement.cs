using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImprovementTracker.Models
{
    public enum Status
    {
        Todo, Inprogress, Done
    }
    public class Improvement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }

}