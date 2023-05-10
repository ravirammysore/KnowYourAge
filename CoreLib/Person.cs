using System.ComponentModel.DataAnnotations;

namespace KnowYourAge.CoreLib;
public class Person
{
    [Required]
    public DateTime DateOfBirth { get; set; }
}
