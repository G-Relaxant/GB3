int quartnum = Input("Введите номер четверти: ");


if(quartnum > 0 && quartnum < 5)
{   if(quartnum == 1)
    {
        Console.WriteLine("Для первой четверти возможны следующие значения координат:");
        Console.WriteLine("Для Х: " + "от " + 1 + " до " + int.MaxValue + " включительно ");
        Console.WriteLine("Для Y: " + "от " + 1 + " до " + int.MaxValue + " включительно ");
    }
    else
    {
        if(quartnum == 2)
        {
            Console.WriteLine("Для второй четверти возможны следующие значения координат:");
            Console.WriteLine("Для Х: " + "от " + -1 + " до " + int.MinValue + " включительно ");
            Console.WriteLine("Для Y: " + "от " + 1 + " до " + int.MaxValue + " включительно ");
        }
        else
        {
            if(quartnum == 3)
            {
                Console.WriteLine("Для третьей четверти возможны следующие значения координат:");
                Console.WriteLine("Для Х: " + "от " + -1 + " до " + int.MinValue + " включительно ");
                Console.WriteLine("Для Y: " + "от " + -1 + " до " + int.MinValue + " включительно ");
            }
            else
            {
                Console.WriteLine("Для третьей четверти возможны следующие значения координат:");
                Console.WriteLine("Для Х: " + "от " + 1 + " до " + int.MaxValue + " включительно ");
                Console.WriteLine("Для Y: " + "от " + -1 + " до " + int.MinValue + " включительно ");
            }
        }
    }
}
else
{
    Console.WriteLine("Вы ввели недопустимое значение четверти, перезапустите программу и введите номер четверти от 1 до 4 включительно");
}



int Input(string output)                           // Инициализация метода ввода-вывода(консоль)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}