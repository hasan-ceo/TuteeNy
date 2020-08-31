using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AVL.Domain.Entities
{
    [Table("Project")]
    public class Project
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public long ProjectId { get; set; }

        [Display(Name = "Project Name")]
        [Required(ErrorMessage = "Please enter a Name")]
        public string ProjectName { get; set; }

        [MaxLength(255)]
        [Display(Name = "Short Description")]
        [Required(ErrorMessage = "Please enter a Name")]
        public string ShortDescription { get; set; }

        [MaxLength(125)]
        [Display(Name = "Thumbnail")]
        public string Thumbnail { get; set; }

        [MaxLength(125)]
        [Display(Name = "Slug")]
        public string Slug { get; set; }

    }
}
