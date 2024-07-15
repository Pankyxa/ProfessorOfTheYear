using System.ComponentModel.DataAnnotations.Schema;

namespace ProfessorOfTheYear.Data
{
    public class ApplicationVote
    {
        public string Id { get; set; }
        
        public string UserId { get; set; }
        public string FormId { get; set; }
        public string ApproverId { get; set; }
        
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        
        [ForeignKey("FormId")]
        public ApplicationForm Form { get; set; }
        
        [ForeignKey("ApproverId")]
        public ApplicationUser ApproverUser { get; set; }
    }
}