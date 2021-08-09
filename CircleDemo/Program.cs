using System;

namespace CircleDemo
{
	class Circle
	{
		public double radius;
		public void Resize(double newR)
		{
			if (newR < 0)
			{
				// If they give us a negative, just don't change it.
				// We won't print out a message or anything.
				return;
			}
			radius = newR;
		}
		public double GetArea()
		{
			return radius * radius * 3.1415926;
		}
		public double GetCircum()
		{
			return 2 * radius * 3.1415926;
		}
		public void Print()
		{
			Console.WriteLine("Here is your circle:");
			Console.WriteLine($"Radius: {radius}");
			Console.WriteLine($"Area: {GetArea()}");
			Console.WriteLine($"Circumference: {GetCircum()}");
		}
	}

	class Program
	{

		// If we weren't modeling something and just needed a function,
		// then we can just make a function. We don't need a whole class.
		// Unless we make one class with a whole bunch of useful functions.
		// But we wouldn't create just one class with one function and
		// nothing else.
		static double AreaOfCircle(double radius)
		{
			return radius * radius * 3.1415926;
		}

		static void Main(string[] args)
		{
			//Console.WriteLine(AreaOfCircle(4.0));

			Circle c1 = new Circle() { radius = 4.0 };
			c1.Print();

			Circle c2 = new Circle() { radius = 3.5 };
			c2.Print();

			c1.Resize(5.5);
			c1.Print();
		}
	}
}
