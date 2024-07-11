namespace ProfessorOfTheYear.Client.Data
{
    public interface ProfessorsDataService
    {
        Task<List<ProfessorInfo>> GetAllProfessorsAsync();
        Task<ProfessorInfo> GetProfessorAsync(string Id);
    }
}
