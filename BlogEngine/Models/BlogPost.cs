using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class BlogPost
    {
        [Key]
        public int BlogPostId
        {
            get;
            set;
        }

        [ForeignKey("User")]
        public int UserId
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string Title
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string ShortDescription
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string Content
        {
            get;
            set;
        }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Posted
        {
            get;
            set;
        }

        [Required]
        public bool IsAvailable
        {
            get;
            set;
        }

        public virtual User User { get; set; }
    }
}
