// 1 Variant
/*int ax = Input("Введите значение X для точки А: ");
int ay = Input("Введите значение Y для точки А: ");
int bx = Input("Введите значение X для точки B: ");
int by = Input("Введите значение Y для точки B: ");

int cx = ax;
int cy = by;

int diffca = cy - ay;
int diffbc = bx - cx;

int kvadrathipot = (diffca * diffca) + (diffbc * diffbc);

int product = 0;
int koren = 0;

while(product < kvadrathipot)
{
    product = koren * koren;
    koren = koren + 1;
}
double korstart = koren - 2;

double product2 = korstart * korstart;

while(product2 < kvadrathipot)
{
    korstart = korstart + 0.01;
    product2 = korstart * korstart;
}

double kor1 = korstart * 100;
int kor2 = Convert.ToInt32(kor1);
double kor3 = Convert.ToDouble(kor2);
double hipot = kor3 / 100;

Console.WriteLine("Расстояние между точками равно " + hipot);



int Input(string output)                           // Инициализация метода ввода-вывода(консоль)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}*/


// 2 Variant
int ax = Input("Введите значение X для точки А: ");
int ay = Input("Введите значение Y для точки А: ");
int bx = Input("Введите значение X для точки B: ");
int by = Input("Введите значение Y для точки B: ");

int cx = ax;
int cy = by;

int diffca = cy - ay;
int diffbc = bx - cx;

double predresult = (Math.Sqrt((diffca * diffca) + diffbc * diffbc));

double kor = predresult * 100;
int kor2 = Convert.ToInt32(kor);
double kor3 = Convert.ToDouble(kor2);
double result = kor3 / 100;

Console.WriteLine("Расстояние между точками равно " + result);



int Input(string output)                           // Инициализация метода ввода-вывода(консоль)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}