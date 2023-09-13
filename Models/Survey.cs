using System.ComponentModel.DataAnnotations;

namespace Survey_with_Validations.Models;

public class Survey
{
    // The get and set keywords in C# are used to create properties. A property is a member of a class that provides a way to get and set the value of a private field. The get keyword is used to define the getter method, which returns the value of the private field. The set keyword is used to define the setter method, which sets the value of the private field.

    [Required(ErrorMessage = "Name is Required")]
    [MinLength(2, ErrorMessage = "Name must be at least two characters")]
    public string Name {get;set;}
    [Required]

    public string Location {get;set;}

    [Required]
    public string Language {get;set;}
    [MinLength(20, ErrorMessage = "Comment must be at least 20 characters.")]
    public string? Comment {get;set;}
}
