Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if(num/10000 == 0){
    Console.Write("Это не пятизначное число :(");
}
else{
    Console.Write(PrintAns(num));
}



int[] SplitIntoNumbers(int number){
    int[] numbers = new int[4];
    numbers[0] = number / 10000;
    numbers[1] = (number / 1000) % 10;
    numbers[2] = (number % 100) / 10;
    numbers[3] = number % 10;
    return numbers;
}
string PrintAns(int number){
    string ans = $"{number} -> ";
    
    if(CompareNumbers(SplitIntoNumbers(number))){
        ans = ans + "да";
    }
    else{
        ans = ans + "нет";
    }
    return ans;
}

bool CompareNumbers(int[] numbers){
    if(numbers[0] == numbers[3] && numbers[1] == numbers[2]){
        return true;
    }
    else{
        return false;
    }
}