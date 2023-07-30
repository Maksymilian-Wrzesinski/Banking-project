/*Height categories:

Height is less than 150 cm = "Dwarf"

Height is between 150 cm and 165 cm = "Average height"

Height is between 165 cm and 195 cm = "Tall"

Height is above 195 cm = "Abnormal height"



Note: 1 inch = 2.54 centimeter

You need to convert the input value (inches) into centimeters.



Eg:

Input: 75

Output: Tall

Pytania do tego zadania
Check your source code with Instructor's solution.*/
class Program
{
    static void Main()
    {

        double input = 25;

        double height = input * 2.54;

        if (height > 195)
        {
            System.Console.WriteLine("Giant");
        }
        else if (height >=165 &&  height <=195)
        {
            System.Console.WriteLine("Tall");
        }
        else if (height >=150 && height <165 )
        {
            System.Console.WriteLine("Small");
        }
        else
        {
            System.Console.WriteLine("Dwarf");
        }

        System.Console.ReadKey();

    }
}
