using System;


namespace eksamen{ 
    internal class Dis1
    {
    public static void Dis2Main()
    {
        //Types 
        int tal = 15;
        char letter = 'a';
        string word = "afadsf";

        //using var
        var tal2 = 15;
        var char2 = 'a';

        //getting types
        Console.WriteLine(tal2.GetType());
        Console.WriteLine(char2.GetType());

        //Type casting
        //Implicit casting
        double tal3 = tal2;
        //explicit casting
        var numberString2 = (double) tal2;




        if(numberString2 is double)
        {
            Console.WriteLine("Im a double");
        }
        else
        {
            Console.WriteLine("Im a not double");
        }



        //null handling

        int? number = null;

        //null propagation
        //if(person != null && person.Name === "Daniel")

        //if(person?.Name === "Daniel")

        //Null-coalescing
        int longNumber = number ?? 11111;


        //string interpolation
        Console.WriteLine($"hej jeg er {longNumber:c5} år gammel");



            //pattern matching
            //En måde man kan matche typer på og så samtidig have en reference til typen uden at skulle typecaste eksplicit. 

            PatternMatching();



        }

        public static void PatternMatching()
        {
            object value = 42;

            if (value is int intValue)
            {
                Console.WriteLine("The value is an integer: " + intValue);
            }
            else if (value is string stringValue)
            {
                Console.WriteLine("The value is a string: " + stringValue);
            }
            else
            {
                Console.WriteLine("The value is of an unknown type.");
            }

            //without pattern matching

/*
if (value is int)
{
int intValue = (int)value;
Console.WriteLine("The value is an integer: " + intValue);
}
*/
}

}

}