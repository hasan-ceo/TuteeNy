using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;
using System.ComponentModel;

namespace AVL.Domain.Entities
{
    public enum REFlagType
    {
        RECEIPTS,
        EXPENDITURE
    }

    public class AccountHeads
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public long AccountHeadsId { get; set; }

        [Required(ErrorMessage = "Please enter a Name")]
        public string Name { get; set; }

        [Display(Name = "Account Type")]
        public long AccountTypeId { get; set; }
        public virtual AccountType AccountType { get; set; }

        [Display(Name = "Main Head")]
        public long AccountParentId { get; set; }
        public virtual AccountParent AccountParent { get; set; }

        [Display(Name = "Rec. / Exp.")]
        public REFlagType REFlag { get; set; }

        [DefaultValue(0)]
        public int AutoAc { get; set; }

    }
}
