using System;

namespace ObjectDemo1
{

	class MyClass
	{
		// member variables
		public int L;
		public int W;

		// member functions (methods)
		public int Area()
		{
			return L * W;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			int x;  // Our basic types such as int, double, decimal, etc. are "value" types. They go on the stack.
			x = 10;
			Console.WriteLine(x);

			MyClass y; // Our classes (and strings!) are objects and go on the heap. So our variable holds a pointer to it.
			y = new MyClass();
			y.L = 15;
			y.W = 20;
			Console.WriteLine(y.Area());

			MyClass z;
			z = new MyClass();
			z.L = 20;
			z.W = 25;
			Console.WriteLine(z.Area());

		}
	}
}
