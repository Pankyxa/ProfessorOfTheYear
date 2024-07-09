using Microsoft.AspNetCore.Identity;

namespace ProfessorOfTheYear.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string PhotoFileName { get; set; }
        public int Birthday { get; set; }
        public string PlaceOfWork { get; set; }
        public string PositionAtWork { get; set; }
        public string Experience { get; set; }
        public string Category { get; set; }
    }

}
