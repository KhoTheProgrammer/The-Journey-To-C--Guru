// 1. Define grading system
// 2. Get users grade
double grade = GetGrade();

char letter = GetLetterGrade(grade);
Console.WriteLine($"The Letter Grade for {grade} is {letter}");

char GetLetterGrade(double grade){
    if (grade >= 0 && grade <= 100){
        if (grade <= 39)return 'F';
        else if (grade <= 59) return 'D';
        else if (grade <= 74) return 'C';
        else if (grade <= 84) return 'B';
        else return 'A';
    }
    return 'X';
}

// Returns a valid grade from user
double GetGrade(){
    while (true){
        Console.Write("Enter your grade: ");
        bool isValid = double.TryParse(Console.ReadLine(), out double grade);
        // Chack if choice is valid
        if (isValid && grade >= 0 && grade <= 100){
            return grade;
        }
    }
}
