namespace ProfessorOfTheYear.Client.Data.About
{
    public interface ProfessorsDataService
    {
        Task<List<ProfessorInfo>> GetAllProfessors();
        Task<ProfessorInfo> GetProfessorIdAsync(string Id);
    }
}
