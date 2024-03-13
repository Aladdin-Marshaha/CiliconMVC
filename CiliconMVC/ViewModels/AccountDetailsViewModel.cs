using CiliconMVC.Models;
using Infrastructure.Entities;

namespace CiliconMVC.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = null!;
    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = null!;
    public UserEntity User { get; internal set; }
}
  