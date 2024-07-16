using System.Net;

namespace ProfessorOfTheYear.Data;

public class File2Type
{
    public string Id { get; set; }
    
    public string TypeId { get; set; }
    public Type Type { get; set; }
    
    public string FileId { get; set; }
    public File File { get; set; }
}