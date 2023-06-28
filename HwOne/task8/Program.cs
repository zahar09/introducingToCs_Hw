Console.Write("Ввидите число: ");
int a  = int.Parse(Console.ReadLine());

Console.Write($"{a}-> ");

for(int i = 2;i <= a;i+=2){
    if(i+2 > a){
        Console.Write($"{i}");
    }
    else{
        Console.Write($"{i}, ");
    }
    
}
