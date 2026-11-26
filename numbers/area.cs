
PrintArea();

void PrintArea(){
    double radius = 2.5;
    double area = Math.PI * radius * radius;
    Console.WriteLine($"Area of a circle with radius: {radius} is: {(area / 100) * 100}");
}