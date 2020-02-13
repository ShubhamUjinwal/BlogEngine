using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Comment
    {
        [Key]
        public int CommentId
        {
            get;
            set;
        }

        [ForeignKey("BlogPost")]
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
        public string Content
        {
            get;
            set;
        }

        [Required]
        public int Rating
        {
            get;
            set;
        }

        public virtual BlogPost BlogPost { get; set; }
        public virtual User User { get; set; }
    }
}
