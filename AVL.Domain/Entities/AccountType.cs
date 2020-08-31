using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;
using System.ComponentModel;

namespace AVL.Domain.Entities
{
    public class AccountType
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public long AccountTypeId { get; set; }

        [Display(Name = "Account Type Name")]
        [Required(ErrorMessage = "Please enter a Name")]
        public string AccountTypeName { get; set; }

    }
}
