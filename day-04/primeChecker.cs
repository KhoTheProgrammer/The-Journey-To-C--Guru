
int num = GetNumber();
bool isPrimeNum = isPrime(num);
Console.WriteLine(isPrimeNum ? $"{num} is a prime number" : $"{num} is not a prime number");

bool isPrime(int num){
    for (int i = 2; i < num; i++){
        if (num % i == 0 ){
            return false;
        }
    }
    return true;
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