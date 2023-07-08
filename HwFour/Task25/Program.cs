//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();

Console.Write("Введите число a : ");
int a  = int.Parse(Console.ReadLine());

Console.Write("Введите число b : ");
int b  = int.Parse(Console.ReadLine());
int _exponentiate = Exponentiate(a,b);
Console.WriteLine($"{a}, {b} -> {_exponentiate}");

int Exponentiate(int num1, int num2){
    int pow = 1;
    for(int i = 0;i < num2;i++){
        pow *= num1;
    }
    return pow;
}