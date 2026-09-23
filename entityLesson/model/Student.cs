using System.ComponentModel.DataAnnotations;

namespace entityLesson.model;

public class Student
{
    public int Id { get; set; }
    
    [MaxLength(15)]
    public string Name { get; set; } = string.Empty;
    
    [MaxLength(20)]
    public string Firstname { get; set; } = string.Empty;
    
    [Range(1, 120)]
    public int Age { get; set; }
    
    [MaxLength(30)]
    public string? Mail { get; set; }
}