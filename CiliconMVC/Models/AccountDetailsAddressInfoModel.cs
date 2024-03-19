using System.ComponentModel.DataAnnotations;

namespace CiliconMVC.Models;

public class AccountDetailsAddressInfoModel
{
    [Display(Name = "Address line 1", Prompt = "Enter your address line", Order = 0)]
    [Required(ErrorMessage = "Enter your address")]
    public string AddressLine_1 { get; set; } = null!;



    [Display(Name = "Address line 2", Prompt = "Enter your second address line", Order = 1)]
    public string? AddressLine_2 { get; set; }



    [Display(Name = "Postal code", Prompt = "Enter your postal code", Order = 2)]
    [Required(ErrorMessage = "Postal code is required")]
    [DataType(DataType.PostalCode)]
    public string PostalCode { get; set; } = null!;



    [Display(Name = "City", Prompt = "Enter your City", Order = 3)]
    [Required(ErrorMessage = "City is required")]
    public string City { get; set; } = null!;
}
