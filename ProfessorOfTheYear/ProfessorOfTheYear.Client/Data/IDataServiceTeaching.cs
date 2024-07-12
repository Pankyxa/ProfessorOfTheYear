namespace ProfessorOfTheYear.Client.Data
{
    public interface IDataServiceTeaching
    {
        Task UpdateAsync(DataTeachingDTO.BaseInformation dto);

        Task<List<DataTeachingDTO.BaseInformation>> GetAllAsync();
    }
}
