using System;

namespace ConstructorDemo
{
	class Rectangle
	{
		private double Length;
		private double Width;

		// Default constructor
		public Rectangle()
		{
			Length = 1;
			Width = 1;
		}

		public Rectangle(double _Length, double _Width)
		{
			//Length = _Length;
			//Width = _Width;
			setLength(_Length);
			setWidth(_Width);
			//Console.WriteLine("I'm inside the constructor");
		}

		// Can't do this. They're the same types as the constructor just above.
		/*public Rectangle(double _Width, double _Length)
		{

		}*/

		public void setLength(double _Length)
		{
			if (_Length < 0)
			{
				_Length = 0;
			}
			if (_Length > 100)
			{
				_Length = 100;
			}
			Length = _Length;
		}

		public double getLength()
		{
			return Length;
		}

		public void setWidth(double _Width)
		{
			if (_Width < 0)
			{
				_Width = 0;
			}
			if (_Width > 100)
			{
				_Width = 100;
			}
			Width = _Width;
		}

		public double getWidth()
		{
			return Width;
		}

		// The public functions are our public "interface" through which we can interact with the class.
		public double GetArea()
		{
			return Length * Width;
		}

		// A static function is shared among all instances.
		/*public static Rectangle Add(Rectangle first, Rectangle second)
		{
			//Rectangle sum = new Rectangle() { Length = first.Length + second.Length, Width = first.Width + second.Width };
			//sum.Length = first.Length + second.Length;
			//sum.Width = first.Width + second.Width;
			//Console.WriteLine(sum.GetArea());
			return sum;
		}*/
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Here's the start of my program");
			Rectangle r1 = new Rectangle(10, 20); // Use a different constructor from default

			//r1.setLength(1000);
			//r1.setWidth(-2000);

			Console.WriteLine(r1.getLength());
			Console.WriteLine(r1.getWidth());
			Console.WriteLine(r1.GetArea());

			Rectangle r2 = new Rectangle(); // Use the default constructor
		}
	}
}
