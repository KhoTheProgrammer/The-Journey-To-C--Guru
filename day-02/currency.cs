const double FXRATE = 4200;

Main();

void Main(){
    // Print Options for Conversion
    Console.WriteLine("Choose an option below");
    Console.WriteLine("1. MWK to USD");
    Console.WriteLine("2. USD to MWK");
    int choice = (int)GetNumber();
    if (choice == 1){
        double mwk = GetNumber();
        double usd = ConvertToDollar(mwk, FXRATE);
        Console.WriteLine($"{mwk} in MWK is {usd:N2} in USD");
    }else if(choice == 2){
        double usd = GetNumber();
        double mwk = ConvertToKwacha(usd, FXRATE);
        Console.WriteLine($"{usd} in MWK is {mwk:N2} in USD");
    }else{
        Console.WriteLine("Please Enter a valid choice");
    }

}

double GetNumber(){
    Console.Write("Enter amount: ");
    double amount;
    bool isValid = double.TryParse(Console.ReadLine(), out amount);
    if (isValid){
        return amount;
    }
    else{
        Console.WriteLine("Please Enter A Valid Number!!!");
        return -1;
    }
}

double ConvertToDollar(double amount, double fxrate){
    return amount / fxrate;
}

double ConvertToKwacha(double amount, double fxrate){
    return amount * fxrate;
}