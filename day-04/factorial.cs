int num = Factorial(17);
Console.WriteLine(num);

int Factorial(int n){
    int ans = 1;
    for (int i = 1; i <= n; i++){
        ans *= i;
    }
    return ans;
}