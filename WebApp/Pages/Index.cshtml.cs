using KnowYourAge.CoreLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KnowYourAge.Pages;

public class IndexModel : PageModel
{
    /*Person object is automatically instantiated by the Razor engine when the form is rendered. 
    This is because the Person property is decorated with the [BindProperty] attribute which tells 
    Razor to create a model binding for the Person object. 
    
    When the form is submitted, the values of the form fields are automatically bound to the 
    corresponding properties of the User object.So, when the OnPostAsync method is called, the 
    Person parameter will contain the values of the form fields, as long as the name attribute of 
    the form fields matches the property names of the Person class */
    
    [BindProperty]
    public Person Person { get; set; }

    public IActionResult OnPostAsync(Person person)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }       
        return RedirectToPage("/Result", new { dateOfBirth = person.DateOfBirth.ToString("dd-MM-yyyy") });
    }
}