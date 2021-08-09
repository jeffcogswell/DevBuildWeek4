using System;

namespace OverloadDemo
{

	class Phone
	{
		public string OS; // iOS10, isOS11, etc., or Android
		public string Provider; // e.g. Verizon, T-Mobile, etc.
		public int Memory; // Memory in gigabytes
		public double Size; // Diagonal screen size

		public bool IsAndroid()
		{
			if (OS.StartsWith("Android"))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Overloading
		// We make multiple "versions" of the same function
		// that take different types of parameters
		// Caveat: Don't go overboard with overloading
		//         In fact, you really don't even need it.
		// Jeff would probably opt to call these functions:
		//         public void UpgradeBy1GB()
		//         public void UpgradeTo(int _Memory)
		//         public void ChangeOS(string _OS)
		//         public void ChangeProvider(string _Provider)
		//         public void ChangeMemoryAndProvider(int _Memory, string _Provider)
		//         public void ChangeMemoryAndOS(int _Memory, string _OS);
		public void Upgrade()
		{
			// Increase the amount of memory
			Memory = Memory + 1;
		}

		public void Upgrade(int _Memory)
		{
			Memory = _Memory;
		}

		/* PLEASE DO NOT DO THIS.
		// This function is way too similar to the one just above it.
		// This is confusing:
		//      myphone.Upgrade(7.0);
		//      myphone.Upgrade(7);
		public void Upgrade(double _Size)
		{
			Size = _Size;
		}*/

		public void Upgrade(string item)
		{
			if (item.StartsWith("iOS") || item.StartsWith("Android"))
			{
				OS = item;
			}
			else if (item == "Verizon" || item == "T-Mobile" || item == "AT&T")
			{
				Provider = item;
			}
		}
		public void Upgrade(int _Memory, string item)
		{
			Memory = _Memory;
			if (item.StartsWith("iOS") || item.StartsWith("Android"))
			{
				OS = item;
			}
			else if (item == "Verizon" || item == "T-Mobile" || item == "AT&T")
			{
				Provider = item;
			}
		}

		public void Print()
		{
			Console.WriteLine("\nSpecs:");
			Console.WriteLine($"OS: {OS}");
			Console.WriteLine($"Provider: {Provider}");
			Console.WriteLine($"Memory: {Memory}GB");
			Console.WriteLine($"Screen Size: {Size}in");
		}

		public override string ToString()
		{
			return $"\n=================INFO ABOUT PHONE INSTANCE==================\nSpecs:\nOS: {OS}\nProvider: {Provider}\nMemory: {Memory}GB\nScreen Size: {Size}in";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Phone myphone = new Phone() { OS = "iOS", Provider = "Verizon", Size = 5.5, Memory = 2 };
			myphone.Print();

			myphone.Upgrade();
			myphone.Print();
			myphone.Upgrade(6);
			myphone.Print();
			myphone.Upgrade("iOS11");
			myphone.Print();
			myphone.Upgrade("T-Mobile");
			myphone.Print();
			myphone.Upgrade(10, "AT&T");
			myphone.Print();

			Console.WriteLine("\nTry out the is-- functions");
			Console.WriteLine("Is this an android?");
			if (myphone.IsAndroid())
			{
				Console.WriteLine("Yup, it's an android");
			}
			else
			{
				Console.WriteLine("Nope, it's something else.");
			}

			myphone.Upgrade("Android 7.2");
			Console.WriteLine("We upgraded! Now is this an android?");
			// This is the same as
			//      if (myphone.IsAndroid() == true)
			if (myphone.IsAndroid())
			{
				Console.WriteLine("Yup, it's an android");
			}
			else
			{
				Console.WriteLine("Nope, it's something else.");
			}


			/*
			// We've been using overloading but didn't realize it.
			// The WriteLine method is overloaded with several types.
			int num = 10;
			string name = "Fred";
			Console.WriteLine(num);
			Console.WriteLine(name);
			Console.WriteLine();
			Console.WriteLine(true);
			Console.WriteLine(3.1415);*/

			// Call WriteLine and our ToString method will get called
			Console.WriteLine(myphone);
			
			// Or we can call ToString directly ourselves and save it in a variable
			string specs = myphone.ToString();
			Console.WriteLine(specs);
		}
	}
}
