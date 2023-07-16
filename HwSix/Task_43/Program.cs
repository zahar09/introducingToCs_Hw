/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double[] point = GetPoint(k1,b1,k2,b2);
Console.WriteLine($"({point[0]}, {point[1]})");

double[] GetPoint(double k1,double b1,double k2,double b2){
    double[] points = new double[2];
    double k = k1 - k2;
    double b = b1 - b2;
    points[0] = Math.Round(b/(-k), 2, MidpointRounding.ToEven);
    points[1] = Math.Round(points[0] * k1 + b1, 2, MidpointRounding.ToEven);
    return points;
}