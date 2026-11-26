const decimal FxRate = 4200m;

Console.WriteLine("Please choose an option below:");
Console.WriteLine("1. MWK to USD");
Console.WriteLine("2. USD to MWK");
int choice = GetChoice();
if (choice == 1){
    decimal mwk = GetAmount("Enter amount in MWK: ");
    decimal usd = mwk / FxRate;
    Console.WriteLine($"{mwk:N2} in MWK is {usd:N2} in USD at the rate of {FxRate}");
}else if (choice == 2){
    decimal usd = GetAmount("Enter amount in USD: ");
    decimal mwk = usd * FxRate;
    Console.WriteLine($"{usd:N2} in USD is {mwk:N2} in MWK at the rate of {FxRate}" );
}else{

}


// Returns a valid choice from user
int GetChoice(){
    while (true){
        Console.Write("Enter your choice: ");
        bool isValid = int.TryParse(Console.ReadLine(), out int choice);
        // Chack if choice is valid
        if (isValid){
            return choice;
        }
    }
}


// Returns a valid amount from user
decimal GetAmount(string prompt){
    while (true){
        Console.Write(prompt);
        bool isValid = decimal.TryParse(Console.ReadLine(), out decimal amount);
        // Chack if choice is valid
        if (isValid){
            return amount;
        }
    }
}