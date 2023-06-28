Console.Write("Ввидите число: ");
int a  = int.Parse(Console.ReadLine());
if(a % 2 == 0){
    Console.WriteLine($"{a} -> четное");
}
else{
    Console.WriteLine($"{a} -> нечетное");
}
