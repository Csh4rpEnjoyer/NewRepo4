using System.Globalization;
Console.WriteLine("Введите x");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k");
int k = int.Parse(Console.ReadLine());
double y = 0;
double w = Math.PI / 180;
double j = Math.Round(Math.Cos(x * w));
double v = Math.Round(Math.Cos(x * w));
while (k > 0)
{
    y = y + j;
    j = j*v;
    k = k - 1;
}
Console.WriteLine(y);

