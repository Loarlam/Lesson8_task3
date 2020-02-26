using System;

namespace Task3
{
    class Accountant
    {
        Post _worker;
        int _hours;

        public Accountant(byte myProfession, int hours)
        {
            switch (myProfession)
            {
                case 1:
                    _worker = Post.tester;
                    break;
                case 2:
                    _worker = Post.programmer;
                    break;
                case 3:
                    _worker = Post.manager;
                    break;
                default:
                    Console.WriteLine("Ошибка! Профессия отсутствует в списке.");
                    break;
            }

            _hours = hours;
        }

        public string SalaryIncreaseDecision
        {
            get
            {
                if (AskForBonus(_worker, _hours))
                    return $"\nДля {_worker} положена премия.";
                else
                    return $"\nВ этом месяце {_worker} без премии.";
            }
        }

        bool AskForBonus(Post worker, int hours)
        {
            switch (worker)
            {
                case Post.tester:
                    if (hours > (int)Post.tester)
                        return true;
                    else
                        return false;
                case Post.programmer:
                    if (hours > (int)Post.programmer)
                        return true;
                    else
                        return false;
                case Post.manager:
                    if (hours > (int)Post.manager)
                        return true;
                    else
                        return false;
                default:
                    return false;
            }
        }
    }
}
