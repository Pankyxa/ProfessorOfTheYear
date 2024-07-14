using System.ComponentModel.DataAnnotations;

namespace ProfessorOfTheYear.Client.Data
{
    public class DataTeachingDTO
    {
        public class BaseInformation
        {
            public int ID { get; set; }

            [Required(ErrorMessage = "Введите ФИО")]
            public string? FullName { get; set; }

            [Required(ErrorMessage = "Укажите дату рождения")]
            public DateOnly? InvoiceDate { get; set; }

            [Required(ErrorMessage = "Введите место работы/учебы")]
            public string? PlaceWork { get; set; }

            [Required(ErrorMessage = "Введите полное название вашей работы")]
            public string? NameWork { get; set; }

            [Required(ErrorMessage = "Введите домашний адрес")]
            public string? HomeAdress { get; set; }

            [Required(ErrorMessage = "Введите контактный телефон")]
            public string? PhoneNumber { get; set; }

            [Required(ErrorMessage = "Введите должность")]
            public string? Post { get; set; }

            [Required(ErrorMessage = "Введите стаж работы")]
            public string? WorkExperience { get; set; }
        }

        public class ScientificInformation
        {
            [Required(ErrorMessage = "Выберите направление конкурса")]
            public string? DirectionCompetition { get; set; }

            [Required(ErrorMessage = "Выберите категорию участника конкурса")]
            public string? CategoryCompetition { get; set; }

            [Required(ErrorMessage = "Выберите ученое звание")]
            public string? ScientificTitle { get; set; }

            [Required(ErrorMessage = "Введите ученую степень")]
            public string? ScientificDegree { get; set; }

            [Required(ErrorMessage = "Введите научную специальность")]
            public string? ScientificSpecialty { get; set; }

            [Required(ErrorMessage = "Введите стаж научно-педагогической деятельности")]
            public string? TeachingExperience { get; set; }
        }
        
        public class LeadershipActivity
        {
            public int? BachelorscCount { get; set; }
            public int? SpecialistsCount { get; set; }
            public int? MastersCount { get; set; }
            public int? CandidatesOfSciencesCount { get; set; }
            public int? DoctorsOfSciencesCount { get; set; }
            //TODO: add fields and validation
        }

        public class ScientificWorks
        {
            //TODO: add fields and validation 
        }

        public class EducationWorks
        {
            //TODO: add fields and validation 
        }
    }
}
