using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;
using System.ComponentModel;

namespace AVL.Domain.Entities
{
    public enum TransType
    {
        CASH,
        BANK
    }

    public class AccountGL
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public long TransID { get; set; }

        //[Required(ErrorMessage = "Please enter a Voucher No")]
        //[ReadOnly(true)]
        public string Vno { get; set; }

        [Required(ErrorMessage = "Please enter Transaction Date")]
        [Display(Name = "Transaction Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime TransDate { get; set; }

        [Display(Name = "Account Head")]
        public long AccountHeadsId { get; set; }
        public virtual AccountHeads AccountHeads { get; set; }

        [Display(Name = "Transaction Type")]
        public TransType TransType { get; set; }

        [DefaultValue(0)]
        public double dr { get; set; }

        [DefaultValue(0)]
        public double cr { get; set; }

        [Required(ErrorMessage = "Please enter particulars")]
        [Display(Name = "Particulars")]
        public string Pat { get; set; }

        [Display(Name = "Date of Entry")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EntryDate { get; set; }

        [HiddenInput(DisplayValue = false)]
        public long? BankId { get; set; }


        [HiddenInput(DisplayValue = false)]
        public long? StudentID { get; set; }

        // [HiddenInput(DisplayValue = false)]
        public string VType { get; set; }

        // [HiddenInput(DisplayValue = false)]
        public string RefID { get; set; }

    }
}
