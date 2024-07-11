namespace ProfessorOfTheYear.Client.Data.About
{
    public class ProfessorsMockData : ProfessorsDataService
    {
        private readonly List<ProfessorInfo> professorInfos = [
            new ProfessorInfo() {
                Name = "Петров Хасбулла Александрович",
                EducationalInstitution = "Высшая школа цифровых технологий",
                AcademicDegree = "Доцент кафедры"
            },
            new ProfessorInfo() {
                Name = "Иванов Сергей Юрьевич",
                EducationalInstitution = "Институт сервиса и отраслевого управления",
                AcademicDegree = "Доктор наук"
            },
            new ProfessorInfo() {
                Name = "Романченко Юлия Владимировна",
                EducationalInstitution = "Институт геологии и нефтегазодобычи",
                AcademicDegree = "Специалист УМР"
            },
            new ProfessorInfo() {
                Name = "Жданова Мария Никитина",
                EducationalInstitution = "Строительный институт",
                AcademicDegree = "Доцент кафедры"
            },
            new ProfessorInfo() {
                Name = "Кригер Александр Васильевич",
                EducationalInstitution = "Институт сервиса и отраслевого управления",
                AcademicDegree = "Доктор наук"
            },
            new ProfessorInfo() {
                Name = "Корнеев Николай Владимирович",
                EducationalInstitution = "Высшая школа цифровых технологий",
                AcademicDegree = "Старший преподаватель"
            },
            new ProfessorInfo() {
                Name = "Квач Татьяна Геннадьевна",
                EducationalInstitution = "Институт геологии и нефтегазодобычи",
                AcademicDegree = "Доцент кафедры"
            },
            new ProfessorInfo() {
                Name = "Токарева Ирина Васильевна",
                EducationalInstitution = "Строительный институт",
                AcademicDegree = "Доктор наук"
            },
            new ProfessorInfo() {
                Name = "Землянов Алексей Анатольевич",
                EducationalInstitution = "Институт транспорта",
                AcademicDegree = "Заведующий лабораторией"
            }
        ];

        public async Task<List<ProfessorInfo>> GetAllProfessors()
        {
            return await Task.FromResult<List<ProfessorInfo>>(professorInfos);
        }
    }
}
