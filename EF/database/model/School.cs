using System.ComponentModel.DataAnnotations;

public class School
{
    [Key]
    public int SchoolID { get; set; }

    public string SchoolName { get; set; }

    public string Description { get; set; }

    public int StudentID { get; set; }

    public Student Student { get; set; }

}