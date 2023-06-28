// See https://aka.ms/new-console-template for more information
Console.Write("Ввидите число a: ");
int a  = int.Parse(Console.ReadLine());
Console.Write("Ввидите число b: ");
int b  = int.Parse(Console.ReadLine());

if(a > b){
    Console.WriteLine($"a = {a}; b = {b} -> max = {a}");
}
else if(b > a){
    Console.WriteLine($"a = {a}; b = {b} -> max = {b}");
}
else{
    Console.WriteLine($"a = {a}; b = {b} -> числа равны");
}

