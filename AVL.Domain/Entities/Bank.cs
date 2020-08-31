using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;
using System.ComponentModel;

namespace AVL.Domain.Entities
{
    public class Bank
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public long BankId { get; set; }


        [Display(Name = "Bank Name")]
        [Required(ErrorMessage = "Please enter a Name")]
        public string BankName { get; set; }
    }
}
