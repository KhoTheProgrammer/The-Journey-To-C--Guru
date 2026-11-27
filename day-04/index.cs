
int i = 0;
// While Loop
Console.WriteLine("***************WHILE LOOP*******************");
while (i < 10){
    Console.Write($"{i} ");
    i++;
}

// Skips a line
Console.WriteLine();

// For Loop
Console.WriteLine("***************FOR LOOP*******************");
for (int j = 0; j <= 5; j++){
    Console.Write(j + " ");
}

// Skips a line
Console.WriteLine();

// For Each Loops
Console.WriteLine("***************FOR EACH LOOP*******************");
string tpin = "7848irtffdf747";
bool isValid = false;
foreach (char digit in tpin){
    bool valid = int.TryParse(digit.ToString(), out int dig);
    if (valid) isValid = true;
    else{
        isValid = false;
        break;
    }
}

Console.WriteLine(isValid);