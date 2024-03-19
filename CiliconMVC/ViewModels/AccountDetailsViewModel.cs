using CiliconMVC.Models;
using Infrastructure.Entities;
using System.Runtime;

namespace CiliconMVC.ViewModels;

public class AccountDetailsViewModel
{
    public ProfileInfoViewModel? ProfileInfo { get; set; } = null!;
    public AccountDetailsBasicInfoModel? BasicInfo { get; set; } = null!;
    public AccountDetailsAddressInfoModel? AddressInfo { get; set; } = null!;

}

