using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessorOfTheYear.Data
{
    public class ApplicationFile
    {
        public string Id { get; set; }
        public string FileName { get; set; }
        
        public string FormId { get; set; }
        
        [ForeignKey("FormId")]
        public ApplicationForm Form { get; set; }
    }
}