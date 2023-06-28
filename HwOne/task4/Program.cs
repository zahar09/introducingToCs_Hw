Console.Write("Ввидите число a: ");
int a  = int.Parse(Console.ReadLine());
Console.Write("Ввидите число b: ");
int b  = int.Parse(Console.ReadLine());
Console.Write("Ввидите число c: ");
int c  = int.Parse(Console.ReadLine());

if(a > b){
    if(a > c){
        Console.WriteLine($"{a}, {b}, {c} -> {a}");
    }
    else{
        Console.WriteLine($"{a}, {b}, {c} -> {c}");
    }
}
else{
    if(b > c){
        Console.WriteLine($"{a}, {b}, {c} -> {b}");
    }
    else{
        Console.WriteLine($"{a}, {b}, {c} -> {c}");
    }
}