namespace ProfessorOfTheYear.Data;

public class File
{
    public string Id { get; set; }
    public string FormId { get; set; }
    public string FileName { get; set; }
    
    public ICollection<File2Type> File2Type { get; set; }
}