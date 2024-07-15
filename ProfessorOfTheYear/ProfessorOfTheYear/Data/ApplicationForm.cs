using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessorOfTheYear.Data
{
    public class ApplicationForm
    {
        public string Id { get; set; }
        
        public string UserId { get; set; }
        
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        
        public string FormName { get; set; }
    }
}