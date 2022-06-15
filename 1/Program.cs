int numberX = Input("Введите значение X: ");
int numberY = Input("Введите значение Y: ");

if(numberX != 0 && numberY != 0)
{   if(numberX > 0 && numberY > 0)
    {
        Console.WriteLine("Координата находится в 1 четверти");
    }
    else
    {
        if(numberX < 0 && numberY > 0)
        {
            Console.WriteLine("Координата находится во 2 четверти");
        }
        else
        {
            if(numberX < 0 && numberY < 0)
            {
                Console.WriteLine("Координата находится в 3 четверти");
            }
            else
            {
                Console.WriteLine("Координата находится в 4 четверти");
            }
        }
    }
}
else
{
    Console.WriteLine("X и/или Y не могут быть равны 0");
}










int Input(string output)                           // Инициализация метода ввода-вывода(консоль)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}