using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImprovementTracker.Models
{
    
    public class Improvement
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public string Description { get; set; }
        public virtual Status Status { get; set; }
        public int StatusId { get; set; }
        
        public static List<Improvement> GetOrderedImprovement(ImprovementTrackerContext db)
        {
            return db.Improvements
                .Where(i => i.Status.IsActive)
                .OrderByDescending(i => i.StatusId).ToList();
        }
        public virtual ICollection<Comment> Comments { get; set; }
    }

}