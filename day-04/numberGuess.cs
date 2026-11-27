Random rand = new Random();

int minValue = 1;
int maxValue = 100;

int guess = rand.Next(minValue, maxValue);;
int value = 0;

while (guess != value){
    value = GetNumber();
}

Console.WriteLine("Congratulations you guessed correctly!!!");


// Returns a valid number from user
int GetNumber(){
    Console.Write("Guess a number between 1 and 100: ");
    while (true){
        bool isValid = int.TryParse(Console.ReadLine(), out int number);
        // Check if number is valid
        if (isValid && number >= 1 && number <= 100){
            return number;
        }else{
            Console.Write("Please enter a valid number (Between 1 and 100): ");
        }
    }
}