int number = Input("Введите число: ");
Console.Write("Квадраты до вашего числа включительно: 1");
int num = 1;
while(num < number)
{
    Console.Write(", ");
    num = num + 1;
    int num2 = Quadro(num);
    Console.Write(num2);
}



int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Quadro(int a)
{
    return a * a;
}