using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction test1 = new Fraction();
        //test1.SetTop(1);
        //test1.SetBottom(1);
        //Console.WriteLine(test1.GetTop());
        //Console.WriteLine(test1.GetBottom());
        string num1 = test1.GetFractionString();
        Console.WriteLine(num1);

        double float1 = test1.GetDecimalValue();
        Console.WriteLine(float1);
        
        Fraction test2 = new Fraction(5);
        //test2.SetTop(5);
        //test2.SetBottom(1);
        //Console.WriteLine(test2.GetTop());
        //Console.WriteLine(test2.GetBottom());
        
        string num2 = test2.GetFractionString();
        Console.WriteLine(num2);

        double float2 = test2.GetDecimalValue();
        Console.WriteLine(float2);

        Fraction test3 = new Fraction(5,4);
        //test3.SetTop(5);
        //test3.SetBottom(4);
        //Console.WriteLine(test3.GetTop());
        //Console.WriteLine(test3.GetBottom());
        string num3 = test3.GetFractionString();
        Console.WriteLine(num3);

        double float3 = test3.GetDecimalValue();
        Console.WriteLine(float3);


        
    }
}