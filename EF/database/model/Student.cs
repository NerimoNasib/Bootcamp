using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class Student
{
    [Key]
    public int StudentID { get; set; }

    public string StudentName { get; set; }

    [Column(TypeName = "TEXT")]
    public string Description { get; set; }
    
    public IEnumerable<School> Schools { get; set; }

}