namespace ProfessorOfTheYear.Client.Data
{
    public class MockDataTeaching: IDataServiceTeaching
    {
        private static readonly List<DataTeachingDTO.BaseInformation> baseInformation=[new DataTeachingDTO.BaseInformation()];

        public async Task UpdateAsync(DataTeachingDTO.BaseInformation taskItem)
        {
            await Task.Run(() =>
            {
                taskItem.ID = baseInformation.Max(t => t.ID) + 1;
                baseInformation.Add(taskItem);
            });
        }

        public async Task<List<DataTeachingDTO.BaseInformation>> GetAllAsync()
        {
            return await Task.FromResult<List<DataTeachingDTO.BaseInformation>>(baseInformation);
        }
    }
}
