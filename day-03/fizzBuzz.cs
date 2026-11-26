int number = GetNumber();
string fizzBuzz = FizzBuzz(number);
Console.WriteLine($"{fizzBuzz}");

string FizzBuzz(int number){
    if (number % 3 == 0 && number % 5 == 0) return "FizzBuzz";
    else if (number % 3 == 0) return "Fizz";
    else if (number % 5 == 0) return "Buzz";
    else return number.ToString();
}

// Returns a valid number from user
int GetNumber(){
    while (true){
        Console.Write("Enter a number: ");
        bool isValid = int.TryParse(Console.ReadLine(), out int number);
        // Check if number is valid
        if (isValid){
            return number;
        }
    }
}