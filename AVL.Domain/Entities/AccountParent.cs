using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;
using System.ComponentModel;

namespace AVL.Domain.Entities
{
    public class AccountParent
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public long AccountParentId { get; set; }


        [Display(Name = "Main Head Name")]
        [Required(ErrorMessage = "Please enter a Name")]
        public string AccountParentName { get; set; }
    }
}
