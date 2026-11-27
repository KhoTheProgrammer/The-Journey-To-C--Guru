int n = GetNumber();
PrintMultiplication(n);

void PrintMultiplication(int n){
    Console.WriteLine("******************MULTIPLICATION TABLE*********************");
    string blank = "X";
    for (int row = 0; row <= n; row++){
        for (int col = 0; col <= n; col++ ){
            if (col == 0 && row == 0){
                Console.Write($"{blank, 5}");
            }else if(col == 0){
                Console.Write($"{row, 5}");
            }else if (row == 0){
                Console.Write($"{col, 5}");
            }else{
                Console.Write($"{col * row, 5}");
            }
        }
        Console.WriteLine();
    }
}

// Returns a valid number from user
int GetNumber(){
    Console.Write("Enter a number (Between 1 - 20): ");
    while (true){
        bool isValid = int.TryParse(Console.ReadLine(), out int number);
        // Check if number is valid
        if (isValid && number >= 1 && number <= 20){
            return number;
        }else{
            Console.Write("Please enter a valid number (Between 1 and 20): ");
        }
    }
}
