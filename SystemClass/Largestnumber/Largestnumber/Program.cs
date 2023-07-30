//Write a C# program to find out largest number among three numbers, using "if".
/*Eg:

num1 = 60

num2 = 45

num3 = 123

Output: 123*/

using System;

class BigNumber
{
    static void Main()
    {
        int num1 = 160;
        int num2 = 245;
        int num3 = 123;

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                System.Console.WriteLine(num1 + " is the largest number");
            }
            else
            {
              System.Console.WriteLine(num3 + " is the largest number");   
            }
        }
        else if (num1 < num2) 
        {
            if (num2 > num3) 
            {
                System.Console.WriteLine(num2 + " is the largest number");
            }
        }
        else
        {
            System.Console.WriteLine(num3 + " is the largest number");
        }
        System.Console.ReadKey();
    }
}