using System;

namespace StaticDemo1
{
	
	//
	// STATIC demonstration
	//

	class Rectangle
	{
		public double Length;
		public double Width;

		public double GetArea()
		{
			return Length * Width;
		}

		// A static function is shared among all instances.
		public static Rectangle Add(Rectangle first, Rectangle second)
		{
			Rectangle sum = new Rectangle() { Length = first.Length + second.Length, Width = first.Width + second.Width };
			//sum.Length = first.Length + second.Length;
			//sum.Width = first.Width + second.Width;
			//Console.WriteLine(sum.GetArea());
			return sum;
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			string entry;
			Console.Write("Please enter a length for your first rectangle: ");
			entry = Console.ReadLine();
			double myLength = double.Parse(entry);

			Console.Write("Please enter a width for your first rectangle: ");
			entry = Console.ReadLine();
			double myWidth = double.Parse(entry);

			Rectangle r1 = new Rectangle() { Length = myLength, Width = myWidth };
			Console.WriteLine("Your new rectangle has these dimensions:");
			Console.WriteLine(r1.Length);
			Console.WriteLine(r1.Width);
			Console.WriteLine(r1.GetArea());

			// Let's hardcode a second rectangle

			Rectangle r2 = new Rectangle() { Length = 1, Width = 2 };

			// Let's call our static Add method to create a new rectangle
			// whose length and width are the sums of the first two.
			// Then we'll print the area of that new one.
			Rectangle r3 = Rectangle.Add(r1, r2);
			Console.WriteLine(r3.GetArea());


		}
	}
}
