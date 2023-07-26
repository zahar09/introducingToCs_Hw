// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int number = 1;
Console.WriteLine();
PrintNumbers(n,number);

void PrintNumbers(int N,int num){
    if(N >= num){
        Console.WriteLine(N);
        N--;
        PrintNumbers(N,num);
    }
}