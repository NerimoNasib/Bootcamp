using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class School
{
    [Key]
    public int SchoolID { get; set; }

    public string SchoolName { get; set; }

    [Column(TypeName = "TEXT")]
    public string Description { get; set; }
    
    public IEnumerable<Student> Students { get; set; }

}