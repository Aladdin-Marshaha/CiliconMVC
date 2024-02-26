using System.ComponentModel.DataAnnotations;
namespace CiliconMVC.Helpers;

public class CheckBoxRequired : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        return value is bool b && b;
    }
}
