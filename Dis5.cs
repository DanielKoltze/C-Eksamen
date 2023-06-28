using System;
namespace eksamen
{
	public class Dis5
	{
		public static void Dis5Main()
		{
			//interfaces
            Square square = new Square();

            //delegates

            DoSomething function;
            function = FunctionOne;
            function?.Invoke(123);
            function = FunctionTwo;
            function?.Invoke(123);

			//multicasting
			DoSomething multicasting;
			multicasting = FunctionOne;
            multicasting += FunctionTwo;
			multicasting?.Invoke(123);

			//events



			//lambda

			var sumOfTwo = (int a, int b) =>
			{
				return a * b;
			};
			var sumOfTwo2 = (int a, int b) => a * b;
        }


		public delegate void DoSomething(int number);

		public static void FunctionOne(int number)
		{
			Console.WriteLine($"Calling function one with {number}");
		}
        public static void FunctionTwo(int number)
        {
            Console.WriteLine($"Calling function two with {number}");
        }




    }



	interface IShape
	{
        public void Draw();
	}

	interface IResizable
	{
		public void Draw();

		public void Resizing()
		{
			Console.WriteLine("Resizing");
		}
	}

	class Square : IShape, IResizable
	{
		void IShape.Draw()
		{
            Console.WriteLine("IShape resize");
        }
        void IResizable.Draw()
        {
            Console.WriteLine("IResizable resize");
        }
    }
}

