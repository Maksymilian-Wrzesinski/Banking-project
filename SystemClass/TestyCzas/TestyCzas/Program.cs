//Write a C# program to print the number of years, days, hours, minutes, seconds - based on given number of seconds.

internal class Program
    {
        static void Main()
        {

        int input = 100000000;

        int seconds = input;
        int seconds_in_min = 60;
        int seconds_int_hour = 60 * 60;
        int seconds_in_day = 60 * 60 * 24;
        int seconds_in_year = 60 * 60 * 24 * 365;

        int years = seconds / seconds_in_year;
        seconds -= years * seconds_in_year;

        int day = seconds / seconds_in_day;
        seconds -= day * seconds_in_day;

        int hour = seconds / seconds_int_hour;
        seconds -= hour * seconds_int_hour;

        int minute = seconds / seconds_in_min;
        seconds -= minute * seconds_in_min;

        System.Console.WriteLine("Years: " + years + " Days: " + day + " Hours: " + hour + " Minutes: " + minute + " Seconds: " + seconds);

        System.Console.ReadKey();




    }
}
