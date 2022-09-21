using System.ComponentModel.DataAnnotations;

namespace TradeCategorization
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
