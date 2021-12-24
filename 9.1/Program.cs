using System;

namespace _9._1
{
    class Program
    {
        struct coworkers
        {
            public int num;
            public string name;
            public DateTime birth;
            public string sex;
            public DateTime employ;
            public string work;
            public int sallary;
        }
        static void Main(string[] args)
        {
            //9.1, 2-й вариант, средний уровень, Гребенюк А. 21-ИСП-2

            Console.WriteLine("Введите число сотрудников: ");
            int w = int.Parse(Console.ReadLine());
            coworkers[] workers = new coworkers[w];
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine("Введите табельный номер: ");
                workers[i].num = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите ФИО сотрудника: ");
                workers[i].name = Console.ReadLine();
                Console.WriteLine("Введите день рождения: ");
                int d1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите месяц рождения: ");
                int m1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите год рождения: ");
                int g1 = int.Parse(Console.ReadLine());
                workers[i].birth = new DateTime(g1, m1, d1);
                Console.WriteLine("Введите пол (муж/жен):");
                workers[i].sex = Console.ReadLine();
                Console.WriteLine("Введите день начала работы: ");
                int d2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите месяц начала работы: ");
                int m2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите год начала работы: ");
                int g2 = int.Parse(Console.ReadLine());
                workers[i].employ = new DateTime(g2, m2, d2);
                Console.WriteLine("Введите должность: ");
                workers[i].work = Console.ReadLine();
                Console.WriteLine("Введите оклад: ");
                workers[i].sallary = int.Parse(Console.ReadLine());
            }
            DateTime localtime = DateTime.Today;
            for (int i = 0; i < workers.Length; i++)
            {
                TimeSpan days = (localtime.Subtract(workers[i].employ));
                Console.WriteLine(workers[i].name + " - " + localtime.Subtract(workers[i].birth) + ", " + days.Days + " Дней на предприятии.");
            }
            DateTime let30 = DateTime.Today.AddYears(-30);
            DateTime penWoman = DateTime.Today.AddYears(-55);
            DateTime penMan = DateTime.Today.AddYears(-60);
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].employ < let30)
                {
                    if (workers[i].sex == "жен")
                    {
                        if (workers[i].birth < penWoman)
                        {
                            Console.WriteLine(workers[i].num + ": " + workers[i].name + "; Дата рождения: " + workers[i].birth + "; Пол: " + workers[i].sex + "; Дата начала работы: " + workers[i].employ + "; Должность: " + workers[i].work + "; Оклад: " + workers[i].sallary);
                        }
                    }
                    if (workers[i].sex == "муж")
                    {
                        if (workers[i].birth < penMan)
                        {
                            Console.WriteLine(workers[i].num + ": " + workers[i].name + "; Дата рождения: " + workers[i].birth + "; Пол: " + workers[i].sex + "; Дата начала работы: " + workers[i].employ + "; Должность: " + workers[i].work + "; Оклад: " + workers[i].sallary);
                        }
                    }
                }
            }
        }
    }
}
