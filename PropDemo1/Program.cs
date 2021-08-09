using System;

namespace PropDemo1
{
	class Rectangle
	{
		private double pWidth;
		private double pHeight;

		// These methods are our "Interface" into the class. These
		// methods are the means through which we interact with the class.
		// Getter and Setter for pWidth
		/*
		public double GetWidth()
		{
			return pWidth;
		}
		public void SetWidth(double _Width)
		{
			if ( _Width < 0 )
			{
				_Width = 0;
			}
			pWidth = _Width;
		}*/
		// Add the same for pHeight.

		// This is a property. It's really two functions. This is NOT a member variable.
		// It only LOOKS like a member variable. The actual member variable is what
		// we're using inside the getter and setter, in this case pWidth.
		public double Width 
		{
			get // Here's the getter function
			{
				//Console.WriteLine("Inside the getter");
				return pWidth;
			}
			set // Here's the setter function
			{
				//Console.WriteLine("Inside the setter");
				if (value < 0)
				{
					value = 0;
				}
				pWidth = value;
			}
		}

		public double Height
		{
			get
			{
				return pHeight;
			}
			set
			{
				pHeight = value;
			}
		}

		// The compiler made a hidden variable behind the scenes
		// And the getter reads the variable
		// And the setter writes to that variable
		public double Length { get; set; }
		// How is this any different from:
		// public double Length;
		// Answer: Today it's no different.
		// Answer 2: When we get to databases, we'll realize it's actually quite different.
		// There's a lot going on behind the scenes, and this functionality is required
		// when using databases.
	}

	class Program
	{
		static void Main(string[] args)
		{
			Rectangle r1 = new Rectangle();
			//r1.SetWidth(-5);
			//Console.WriteLine(r1.GetWidth()); // Expecting to see a 0
			//r1.SetWidth(20);
			//Console.WriteLine(r1.GetWidth()); // Expecting to see a 20

			// Programmers really like to do something like this:
			// We can use the getter and setter by using syntax that looks like
			// we're just reading and writing a member variable. But we aren't.
			// We're actually calling the getter and setter functions.
			r1.Width = -5;
			Console.WriteLine(r1.Width); // Expecting to see a 0
			r1.Width = 20;
			Console.WriteLine(r1.Width); // Expecting to see a 20
			r1.Height = 30;
			Console.WriteLine(r1.Height); // Expecting 30
			r1.Length = 50;
			Console.WriteLine(r1.Length); // Expecting 50
		}
	}
}
