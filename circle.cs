// Calculate Circumference of circle

using System;

public class circle{
    public static void Main(){
        Console.WriteLine("Enter Radius of Circle:");
        int rad = int.Parse(Console.ReadLine());
        double PI = 3.14;
        double circumference = 2 * PI * rad;
        
        Console.WriteLine("Radius: {0}", rad);
        Console.WriteLine("Circumference: {0}", circumference);
    }
}
