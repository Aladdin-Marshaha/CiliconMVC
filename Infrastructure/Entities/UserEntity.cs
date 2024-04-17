  using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class UserEntity : IdentityUser
{
    [ProtectedPersonalData]
    public string FirstName { get; set; } = null!;
    
    [ProtectedPersonalData]
    public string LastName { get; set; } = null!;

    [ProtectedPersonalData]
    public string? Bio {  get; set; }

    public string? ProfileImage { get; set; } = "avatar.png";

    public ICollection<AddressEntity> addresses { get; set; } = [];
    public bool IsExternalAccount { get; set; } = false;
}
