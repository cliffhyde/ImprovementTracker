using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ImprovementTracker.Models
{
    public class Comment     {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings=false),MaxLength(40, ErrorMessage="Your Comment is too long")]
        public string CommentText { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]    
        public DateTime CreatedOn { get; set; }
        public int ImprovementId { get; set; }
        public virtual Improvement Improvement { get; set; }
    }
}