using System;

namespace Task3
{
    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            switch (worker)
            {
                case Post.tester:
                    if (hours > (int)Post.tester)
                        Console.WriteLine($"\nДля {worker} положена премия.");
                    else
                        Console.WriteLine($"\nВ этом месяце {worker} без премии.");
                    break;
                case Post.programmer:
                    if (hours > (int)Post.programmer)
                        Console.WriteLine($"\nДля {worker} положена премия.");
                    else
                        Console.WriteLine($"\nВ этом месяце {worker} без премии.");
                    break;
                case Post.manager:
                    if (hours > (int)Post.manager)
                        Console.WriteLine($"\nДля {worker} положена премия.");
                    else
                        Console.WriteLine($"\nВ этом месяце {worker} без премии.");
                    break;
                default:
                    break;
            }
            return false;
        }
    }
}
