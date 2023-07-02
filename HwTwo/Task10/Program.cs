Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int num2 = (num / 10) % 10;
Console.WriteLine($"Вторая цыфра числа {num} - {num2}");