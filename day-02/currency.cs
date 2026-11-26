Console.Write("Enter amount in MWK: ");
double amount;
bool isValid = double.TryParse(Console.ReadLine(), out amount);
if (isValid){
    Console.WriteLine($"Amoount: {amount}");
}
else{
    Console.WriteLine($"Conversion is unsuccessful");
}
