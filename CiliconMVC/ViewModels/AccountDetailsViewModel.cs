using CiliconMVC.Models;

namespace CiliconMVC.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    {
        FirstName = "Aladdin",
        LastName = "Marshaha",
        Email = "aladdin@gmail.com",
        ProfileImage = "images/profile-imge.svg"
    };
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
}
  