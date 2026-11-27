int num = GetNumber();
int result = SumOfDigitsV2(num);
Console.WriteLine($"The sum of digits in {num} is: {result}");

int SumOfDigitsV1(int num){
    int sum = 0;
    foreach (char x in num.ToString()){
        sum += int.Parse(x.ToString());
    }
    return sum;
}

int SumOfDigitsV2(int num){
    int sum = 0;
    while (num > 0){
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

// Returns a valid number from user
int GetNumber(){
    Console.Write("Enter a positive number : ");
    while (true){
        bool isValid = int.TryParse(Console.ReadLine(), out int number);
        // Check if number is valid
        if (isValid && number >= 0){
            return number;
        }else{
            Console.Write("Please enter a valid positive number: ");
        }
    }
}