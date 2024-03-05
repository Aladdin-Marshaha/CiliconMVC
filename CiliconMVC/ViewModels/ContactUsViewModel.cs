using CiliconMVC.Models;

namespace CiliconMVC.ViewModels;

public class ContactUsViewModel
{
    public string Title { get; set; } = "Contact Us";
    public ContactUsModel ContactUs { get; set; } = new ContactUsModel();
}
