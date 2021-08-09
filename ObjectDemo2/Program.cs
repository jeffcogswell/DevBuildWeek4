using System;

namespace ObjectDemo2
{

	class Rectangle
	{
		public int L;
		public int W;

		public int Area()
		{
			return L * W;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			// Let's try copying object variables around

			// But first do it with integers to compare

			int x;
			x = 10;
			int y;
			y = x;
			// So now y has 10

			// Now change x
			x = 15;

			// Now what is in y?
			// We didn't change y, so it still has a 10 in it
			// Console.WriteLine(y);

			// Now let's make an instance of Rectangle

			Rectangle first;
			first = new Rectangle() { L = 15, W = 20 }; // Member initialization
			Console.WriteLine(first.L);
			Console.WriteLine(first.Area());

			Rectangle second;
			second = first;
			Console.WriteLine(second.Area());

			second.L = 25;
			Console.WriteLine(first.L);

			
		}
	}
}
