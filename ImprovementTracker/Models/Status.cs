using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImprovementTracker.Models
{
    public class Status
    {
        public Status()
        {
            this.IsActive = false;
        }
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string  StatusName { get; set; }

        [Required]
        public bool  IsActive { get; set; }
    }
}