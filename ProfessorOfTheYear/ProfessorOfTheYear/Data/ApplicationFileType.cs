using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessorOfTheYear.Data
{
    public class ApplicationFileType
    {
        public string Id { get; set; }
        
        public string FileId { get; set; }
        public string TypeId { get; set; }
        
        [ForeignKey("FileId")]
        public ApplicationForm File { get; set; }
        
        [ForeignKey("TypeId")]
        public ApplicationType Type { get; set; }
    }
}