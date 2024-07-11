namespace ProfessorOfTheYear.Client.Model
{
    public class Form
    {
        public int selectionOfCompetition { get; set; } = 0;
        public int selectionOfCategory { get; set; } = 0;
        public string WorkName { get; set; } = string.Empty;
        public string PlaceOfWork {  get; set; } = string.Empty;
        public string Info {  get; set; } = string.Empty;
        public string FullName {  get; set; } = string.Empty;
        public DateOnly Birthday { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public string Post { get; set; } = string.Empty;
        public string Experience { get; set; } = string.Empty;
    }
}
