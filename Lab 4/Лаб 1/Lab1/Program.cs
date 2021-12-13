using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1
{
    public class ClassInfo
    {
        public int Id { get; set; }
        public string Name_employee { get; set; }
    }
    public class Info
    {
        public string Name_employee { get; set; }
        public string Workplace_address { get; set; }
        public string The_presence_of_diphtheria_vaccination { get; set; }

    }
    class Program
    {
        static async void Main(string[] args)
        {
            await Task.Run(() => {
                var classInfo = new List<ClassInfo>()
            {
                new ClassInfo()
                {
                    Id = 1,
                    Name_employee = "Лозан С.Л."
                },
                new ClassInfo()
                {
                    Id = 2,
                    Name_employee = "Курах Є.О."
                },
                new ClassInfo()
                {
                    Id = 3,
                    Name_employee = "Власюк О.І."
                },
                new ClassInfo()
                {
                    Id = 4,
                    Name_employee = "Маргітич О.В."
                },
                new ClassInfo()
                {
                    Id = 5,
                    Name_employee = "Сливка І.І."
                },
            };
                var info = new List<Info>()
            {
                new Info()
                {
                    Name_employee = "Лозан С.Л.",
                    Workplace_address = "Берегівська ЗОШ",
                    The_presence_of_diphtheria_vaccination = "Вакцинована"

                },
                new Info()
                {
                    Name_employee = "Курах Є.О.",
                    Workplace_address = "Берегівська ЗОШ",
                    The_presence_of_diphtheria_vaccination = "Вакцинований"
                },
                new Info()
                {
                    Name_employee = "Власюк О.І.",
                    Workplace_address = "Берегівська ЗОШ",
                    The_presence_of_diphtheria_vaccination = "Вакцинований"
                },
                new Info()
                {
                    Name_employee = "Маргітич О.В.",
                    Workplace_address = "Берегівська ЗОШ",
                    The_presence_of_diphtheria_vaccination = "Не вакцинована"
                },
                new Info()
                {
                    Name_employee = "Сливка І.І.",
                    Workplace_address = "Берегівська ЗОШ",
                    The_presence_of_diphtheria_vaccination = "Не вакцинований"
                }
            };
                var c = info[1];
                var infor = info
                    .Join(classInfo,
                        c => c.Name_employee,
                        n => n.Id,
                        (c, n) => new
                        {
                            Name_employee = c.Name_employee,
                            Workplace_address = n.Name_employee,
                            The_presence_of_diphtheria_vaccination = c.The_presence_of_diphtheria_vaccination
                        });

                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(info));
                Console.ReadKey();
            }
    }
    } }