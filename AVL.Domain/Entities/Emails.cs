using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;
using System.ComponentModel;

namespace AVL.Domain.Entities
{
    public class Emails
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public long EmailsID { get; set; }

        [Required, Display(Name = "Name")]
        public string FromName { get; set; }

        [Required, Display(Name = "Email"), EmailAddress]
        public string FromEmail { get; set; }

        [Required, Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

    }
}
