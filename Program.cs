using System;
class Program
{
    public static void Main(string[] args)
    {
        int Input1, Input2, Input3, Ans;
     Console.Write("Please input number 1:");
     Input1 = int.Parse(Console.ReadLine());
     Console.Write("Please input number2:");
     Input2 = int.Parse(Console.ReadLine());
     Console.Write("PLease input number 3:");
     Input3 = int.Parse(Console.ReadLine());

    Ans = Input1+Input2+Input3 ; 

    Console.WriteLine("Sum :{0}",Ans);
    }
}