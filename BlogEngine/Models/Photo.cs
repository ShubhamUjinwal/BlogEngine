using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId
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

        [Required]
        [StringLength(1000)]
        public string FileName
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string Url
        {
            get;
            set;
        }

        public virtual BlogPost BlogPost { get; set; }
    }
}
