using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AVL.Domain.Entities
{
    [Table("Institute")]
    public class Institute
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public long InstituteID { get; set; }

        [MaxLength(255)]
        [Display(Name = "Institute Name")]
        public string InstituteName { get; set; }      
    }
}
