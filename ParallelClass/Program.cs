using System;

namespace ParallelClass
{
	class Parallelogram
	{
		public double Length;
		public double Width;
		public double GetArea()
		{
			return Length * Width;
		}
		public double GetPerimeter()
		{
			return Length + Length + Width + Width;
		}
		public void Print()
		{
			Console.WriteLine("Here is your Parallelogram:");
			Console.WriteLine($"Length: {Length}, Width: {Width}");
			Console.WriteLine($"Area: {GetArea()}, Perimeter: {GetPerimeter()}");
		}

		//
		// Documentation would look like this:
		//
		//       public void Resize(double _Length, double _Width)
		//
		//           The _Length parameter specifies the new length for the rectangle.
		//           The _Width paremter specifies the new width for the rectangle.
		//
		//    _Length < 0 || _Width < 0 then return
		//    _Length >= 0 && _Width >= 0 then do the change
		public bool Resize(double _Length, double _Width)
		{
			if (_Length >=0 && _Width >= 0)
			{
				Length = _Length;
				Width = _Width;
				return true;
			}
			else
			{
				return false;
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Parallelogram p1 = new Parallelogram() { Length = 20.5, Width = 30.2 };
			p1.Print();

			if (p1.Resize(10, 20) == false)
			{
				Console.WriteLine("Sorry both numbers must be 0 or positive");
			}
			p1.Print();
		}
	}
}
