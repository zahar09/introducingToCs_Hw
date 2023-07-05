Console.WriteLine("Введите координаты первой точки");
Console.Write("координата X1 -> ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("координата Y1 -> ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("координата Z1 -> ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("координата X2 -> ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("координата Y2 -> ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("координата Z2 -> ");
double z2 = Convert.ToDouble(Console.ReadLine());

double length = Math.Round(Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2)),2, 
    MidpointRounding.ToEven);
           
Console.WriteLine($"Растояние между первой точкой {x1},{y1},{z1} и второй точкой {x2},{y2},{z2} " +
    $"равно {length}");
