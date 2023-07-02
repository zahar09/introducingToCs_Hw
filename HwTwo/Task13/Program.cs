//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if(num < 100){
    Console.WriteLine("У этого числа нет третьей цифры");
}
else{
    int ans = num;
    while(ans > 999){
        ans /= 10;
    }
    Console.WriteLine($"третья цифра числа {num} - {ans % 10}");
}