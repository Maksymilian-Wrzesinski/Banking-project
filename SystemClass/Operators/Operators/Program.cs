class Sample
{
    static void Main()
    {
        //Arithimetical
        decimal a = 10M;
        System.Console.WriteLine(a);
        decimal b = 3M;
        System.Console.WriteLine(b);
        decimal c = a + b;
        System.Console.WriteLine(c);



        a += 20M;
        System.Console.WriteLine(a);
        a -= 20M;
        System.Console.WriteLine(a);
        a *= +3M;
        System.Console.WriteLine(a);
        a /= 3M;
        System.Console.WriteLine(a);

        //Increment
        a = 10M;
        System.Console.WriteLine(++a);
        System.Console.WriteLine(a++);
        System.Console.WriteLine(a);
        a = 10M;

        //Comparision
        System.Console.WriteLine();
        bool b1 = a == 10;
        System.Console.WriteLine(b1);
        bool b2 = a != 10;

        //Logical
        System.Console.WriteLine();
        bool b7 = a == 10 & b == 10;
        System.Console.WriteLine(b7);
        bool b8 = a == 10 && b == 10;
        System.Console.WriteLine(b8);
        bool b9 = a == 10 | b == 10;
        System.Console.WriteLine(b9);

        //concatenation
        string name = "Scott";
        int age = 10;
        string message = "Hey " + name + ", your age is " + age + ".";
        System.Console.WriteLine(message);

        //ternary
        string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager":"Adult";
        System.Console.WriteLine(title);

        //operator precedence
        double z = 10 + 4 * 30 / 10;
        System.Console.WriteLine(z);

        System.Console.ReadKey();
    }
}