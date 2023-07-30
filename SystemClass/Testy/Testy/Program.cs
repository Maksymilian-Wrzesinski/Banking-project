//ite a C# program to get nearest thousand of given integer number. Here, let name the input value as "number".
/*If the number's last three digits are greater than or equal to 500; it should "round up" the number.

If the number's last three digits are less than 500; it should "round down" the number.

If the number is less than 500; it should round up to 1000.*/


class Numbers
{
    static void Main()
    {
        int number = 8888;


        int roundup = number / 1000 * 1000;

        int lastthreedigits = (number  >= 500 && number <= 1000) ? 1000 : 0;
        int lessthanfiveh = (number < 500) ? 1000 : 0;

        int combine = roundup + lastthreedigits + lessthanfiveh;

        System.Console.WriteLine(roundup);
        System.Console.WriteLine(lastthreedigits);
        System.Console.WriteLine(combine);
        System.Console.ReadKey();


    }
}