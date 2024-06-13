using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class Student
{
    [Key]
    public int StudentID { get; set; }

    public string StudentName { get; set; }

    public string Description { get; set; }

    public int SchoolID { get; set; }

    public School School { get; set; }

}