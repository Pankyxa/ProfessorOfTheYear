using System.ComponentModel.DataAnnotations;

namespace ProfessorOfTheYear.Client.Data
{
    public class DataTeachingDTO
    {
        public class BaseInformation
        {
            public int ID { get; set; }
            [Required(ErrorMessage = "Выберите направление конкурса")]
            //[Range(1, 3, ErrorMessage = "Выберите направление конкурса")]
            public string? DirectionCompetition { get; set; }

            [Required(ErrorMessage = "Выберите категорию участника конкурса")]
            //[Range(1, 3, ErrorMessage = "Выберите направление конкурса")]
            public string? CategoryCompetition { get; set; }

            [Required(ErrorMessage = "Введите полное название вашей работы")]
            public string? NameWork { get; set; }

            [Required(ErrorMessage = "Введите ФИО")]
            public string? FullName { get; set; }

            [Required(ErrorMessage = "Укажите дату рождения")]
            public DateOnly? InvoiceDate { get; set; }

            [Required(ErrorMessage = "Введите место работы/учебы")]
            public string? PlaceWork { get; set; }

            [Required(ErrorMessage = "Введите должность")]
            public string? Post { get; set; }

            [Required(ErrorMessage = "Введите стаж работы")]
            public string? WorkExperience { get; set; }

        }
    }
}
