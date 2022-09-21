using System.ComponentModel.DataAnnotations;

namespace TradeCategorization.Model.Enum
{
    public enum Category
    {
        [Display(Name = "EXPIRED")]
        EXPIRED,
        [Display(Name = "HIGHRISK")]
        HIGHRISK,
        [Display(Name = "MEDIUMRISK")]
        MEDIUMRISK
    }
}
