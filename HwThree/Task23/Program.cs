Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
PrintCubeTable(num);


void PrintCubeTable(int number){
    Console.Write($"{number} -> ");
    for(int i = 1;i < number;i++){
        Console.Write($"{i*i*i}, ");
    }
    Console.Write($"{number * number * number}");
}