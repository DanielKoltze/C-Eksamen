using System;
namespace eksamen
{
	public class Dis4
	{
		public static void Dis4Main()
		{
			var circle = new Circle(1);
			var circle2 = circle;
            Console.Write(circle.Diameter);

			var person = new Person("Dnaiel", 23);
			person.PrintMe();

			var ColoredCircle = new ColoredCircle("Green", 6);
            Console.Write(ColoredCircle.Diameter);
			Circle ColeredCircle2 = new ColoredCircle("Yellow", 10);


			Circle circleTest = new Circle(1);
            Circle coloredCircle = new ColoredCircle("green", 1);
            Circle threeCircle = new ThreeDCircle(1);

			Circle[] circles = { circleTest, coloredCircle, threeCircle };

			foreach(Circle circle1 in circles)
			{
				circle1.Draw();
			}
		
        }
	}

}



class Circle
{
	public int Radius { get; set; }
	public int Diameter{
		get => Radius * 2;
	}

	public Circle(int radius)
	{
		this.Radius = radius;
	}

	public void Draw()
	{
		Console.WriteLine("Drawing circle");
	}
}


class ColoredCircle : Circle
{
	public string Color { get; set; }

	public ColoredCircle(string color, int radius)
	: base(radius)
	{
		this.Color = color;
	}

    public void Draw()
    {
        Console.WriteLine("Drawing ColoredCircle");
    }

}


class ThreeDCircle : Circle
{


    public ThreeDCircle( int radius)
    : base(radius)
    {
    }

    public void Draw()
    {
        Console.WriteLine("Drawing 3DCircle");
    }

}




record Person(string name, int age)
{
	public void PrintMe()
	{
		Console.WriteLine($"my name is {name} and i am {age} years old");
	}
}

