/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант. 
Присвойте каждой константе значение,  задающее количество часов, которые должен отработать сотрудник за месяц.  
Создайте класс  Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему положена премия. 
*/
using System;

namespace Task3
{
    enum Post
    {
        tester = 160,
        programmer = 124,
        manager = 140
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accountant accountant;
            byte myProfession = 0;
            int hoursWorkedInMonth = 0;

            Console.Write("1 - тестировщик\n2 - программист\n3 - менеджер\nМой ответ = ");
            myProfession = Byte.Parse(Console.ReadLine());

            Console.Write("\nКоличество отработанных часов в месяц = ");
            hoursWorkedInMonth = Int32.Parse(Console.ReadLine());

            accountant = new Accountant();

            switch (myProfession)
            {
                case 1:
                    accountant.AskForBonus(Post.tester, hoursWorkedInMonth);
                    break;
                case 2:
                    accountant.AskForBonus(Post.programmer, hoursWorkedInMonth);
                    break;
                case 3:
                    accountant.AskForBonus(Post.manager, hoursWorkedInMonth);
                    break;
                default:
                    Console.WriteLine("Ошибка! Профессия отсутствует в списке.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
