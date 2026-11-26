
int year = GetYear();
bool isLeap = IsLeapYear(year);
Console.WriteLine(isLeap ? $"{year} is a leap year." : $"{year} is not a leap year.");

bool IsLeapYear(int year){
    if (year % 4 == 0){
        if (year % 100 == 0 && year % 400 != 0){
            return false;
        }
        return true;
    }
    return false;
}

// Returns a valid number from user
int GetYear(){
    Console.Write("Enter year: ");
    while (true){
        bool isValid = int.TryParse(Console.ReadLine(), out int year);
        // Check if number is valid
        if (isValid){
            return year;
        }else{
            Console.Write("Please enter a valid year: ");
        }
    }
}