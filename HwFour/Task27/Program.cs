//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int[] digitsFromNumber = MakeDigitsFromNumber(num);
int sumOfDigitsFromnumber = SumOfNumbers(digitsFromNumber);
Console.WriteLine($"{num} -> {sumOfDigitsFromnumber}");

int SumOfNumbers(int[] numbers){
    int sum = 0;
    for(int i = 0;i < numbers.Length;i++){
        sum += numbers[i];
    }
    return sum;
}


int[] MakeDigitsFromNumber(int number){
    int size = 1;
    int number1  = number;
    while((number1 / 10) != 0){
        number1 /= 10;
        size++;
    }
    //Console.WriteLine(size);
    int[] numbers = new int[size];
    for(int i = 0;i < size;i++){
        //Console.WriteLine(number);
        numbers[i] = number % 10; 
        number /= 10;
    }
    //Console.Write(numbers[0]);
    //Console.Write(numbers[1]);
    //Console.WriteLine(numbers[2]);
    return numbers;
}