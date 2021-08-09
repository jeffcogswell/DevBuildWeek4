using System;

namespace AccessDemo
{

	//
	// Access Modifiers demonstration
	//

	class Rectangle
	{
		private double Length;
		private double Width;

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
			Rectangle r1 = new Rectangle();
			r1.setLength(1000);
			r1.setWidth(-2000);

			Console.WriteLine(r1.getLength());
			Console.WriteLine(r1.getWidth());

			Console.WriteLine(r1.GetArea());
		}
	}
}
