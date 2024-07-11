namespace ProfessorOfTheYear.Client.Data.About
{
    public class ProfessorsMockData : ProfessorsDataService
    {
        private readonly List<ProfessorInfo> professorInfos = [
            new ProfessorInfo() {
                Id="654dv65dv65vd",
                Name = "Петров Хасбулла Александрович",
                EducationalInstitution = "Высшая школа цифровых технологий",
                AcademicDegree = "Доцент кафедры"
            },
            new ProfessorInfo() {
                Id="z12cxzcx12x",
                Name = "Иванов Сергей Юрьевич",
                EducationalInstitution = "Институт сервиса и отраслевого управления",
                AcademicDegree = "Доктор наук"
            },
            new ProfessorInfo() {
                Id="cs56zc4zs6c",
                Name = "Романченко Юлия Владимировна",
                EducationalInstitution = "Институт геологии и нефтегазодобычи",
                AcademicDegree = "Специалист УМР"
            },
            new ProfessorInfo() {
                Id="4vz5cas4848sw8s",
                Name = "Жданова Мария Никитина",
                EducationalInstitution = "Строительный институт",
                AcademicDegree = "Доцент кафедры"
            },
            new ProfessorInfo() {
                Id = "z45cs5ca54c4",
                Name = "Кригер Александр Васильевич",
                EducationalInstitution = "Институт сервиса и отраслевого управления",
                AcademicDegree = "Доктор наук"
            },
            new ProfessorInfo() {
                Id="sc5zs",
                Name = "Корнеев Николай Владимирович",
                EducationalInstitution = "Высшая школа цифровых технологий",
                AcademicDegree = "Старший преподаватель"
            },
            new ProfessorInfo() {
                Id="4czc4xc5",
                Name = "Квач Татьяна Геннадьевна",
                EducationalInstitution = "Институт геологии и нефтегазодобычи",
                AcademicDegree = "Доцент кафедры"
            },
            new ProfessorInfo() {
                Id="sc4scc44c4c4c",
                Name = "Токарева Ирина Васильевна",
                EducationalInstitution = "Строительный институт",
                AcademicDegree = "Доктор наук"
            },
            new ProfessorInfo() {
                Id="s77s7s777x4x",
                Name = "Землянов Алексей Анатольевич",
                EducationalInstitution = "Институт транспорта",
                AcademicDegree = "Заведующий лабораторией"
            }
        ];

        public async Task<List<ProfessorInfo>> GetAllProfessors()
        {
            return await Task.FromResult<List<ProfessorInfo>>(professorInfos);
        }

        public async Task<ProfessorInfo> GetProfessorIdAsync(string Id)
        {
            return await Task.FromResult<ProfessorInfo>(professorInfos.First(x => x.Id == Id));
        }
    }
}
