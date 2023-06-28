using System;
using System.ComponentModel.DataAnnotations;
namespace eksamen
{
	public class Dis2
	{
       
		public static void Dis2Main()
		{



			//tuple
			(string, int) tuple = ("hi", 2);
			Console.WriteLine(tuple);

            //deconstruction
            var (message, number) = tuple;
            Member member = new Member("Daniel", 23);
            var (name, age) = member;
            //discard
            var (name3, _) = member;
            //error handling
            Error();
            // bruge throw
            //Divide(10,0)


            //attributes
            //[Required]
            string name2 = null;
            Console.WriteLine(checkAttribute(name2));

		}
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Divisor cannot be zero.");
            }

            return dividend / divisor;
        }

        public static bool checkAttribute(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var validationResults = new System.Collections.Generic.List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, validationResults, true);
        }

		public static (int,string) Method1()
		{
			return (13, "Hej");
		}

        public static void Error()
        {
            try
            {
                string text = null;
                Console.WriteLine(text.ToUpper());
            }
            catch (NullReferenceException ex)
            { 
                Console.WriteLine("Null reference exception occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }


    }
}


class Member
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Member(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Deconstruct(out string name, out int age)
    {
        name = Name;
        age = Age;
    }
}