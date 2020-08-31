using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;
using System.ComponentModel;

namespace AVL.Domain.Entities
{
    public class BusinessDay
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public long BusinessDayID { get; set; }


        [Required(ErrorMessage = "Please enter From Date")]
        [Display(Name = "From Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime WorkDate { get; set; }

        public bool DayClose { get; set; }
    }
}
