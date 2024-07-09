namespace ProfessorOfTheYear.Data;

public class Type
{
    public string Id { get; set; }
    public string Mnemotic { get; set; }
    public string Name { get; set; }
    
    public ICollection<File2Type> File2Type { get; set; }
}