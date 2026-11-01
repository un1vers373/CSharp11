using System;
namespace c1
{
    class Program
    {
        static void Main()
        {
            int number = -1;
            while (number != 0)
            {
                Console.WriteLine("1 - Проверить возраст");
                Console.WriteLine("2 - Проверить диапазон");
                Console.WriteLine("3 - Информация о программе");
                Console.WriteLine("0 - Выход");
                number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Введите ваш возраст: ");
                        int age = int.Parse(Console.ReadLine());
                        if (age >= 18)
                        {
                            Console.WriteLine("Вы совершеннолетний!");
                        }
                        else
                        {
                            Console.WriteLine("Вы несовершеннолетний!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите число: ");
                        age = int.Parse(Console.ReadLine());
                        if (age >= 10 && age <= 20)
                        {
                            Console.WriteLine("Число находится в диапазоне от 10 до 20!");
    
                        }
                        else
                        {
                            Console.WriteLine("Число не находится в диапазоне от 10 до 20!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Я изучаю язык программирования C#!");
                        break;
                    case 0:
                        Console.WriteLine("Выход из программы, пока прощай!");
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда, попробуйте снова!");
                        break;
                }
            }
        }
    }
}

