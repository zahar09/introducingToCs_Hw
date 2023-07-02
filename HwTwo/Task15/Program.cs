// See https://aka.ms/new-console-template for more information
Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());

if(day > 7 || day < 1){
    Console.WriteLine("Токого дня недели нет) ");
}
else if(day == 7 || day == 6){
    Console.WriteLine("Это выходной :)");
}
else{
    Console.WriteLine("Это рабочий день недели :(");
}