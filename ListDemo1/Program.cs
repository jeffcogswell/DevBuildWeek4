using System;
using System.Collections.Generic;

namespace ListDemo1
{
	class Person
	{
		// Here are the private members
		private string pName;
		private string pEmail;

		// Here are the public getters and setters
		public string GetName()
		{
			return pName;
		}
		public void SetName(string _Name)
		{
			// Demo of how to guard against bad data
			if (_Name == "")
			{
				_Name = "EMPTY";
			}
			pName = _Name;
		}
		public string GetEmail()
		{
			return pEmail;
		}
		public void SetEmail(string _Email)
		{
			pEmail = _Email;
		}

		public override string ToString()
		{
			return $"{pName}, {pEmail}";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person();
			p1.SetName("Fred Johnson");
			Console.WriteLine(p1.GetName()); // Expect Fred Johnson on the console
			p1.SetEmail("fred@rocket.com");
			Console.WriteLine(p1.GetEmail()); // Expect fred@rocket.com

			Person p2 = new Person();
			p2.SetName("Sally Smith");
			Console.WriteLine(p2.GetName()); // Expect Sally Smith
			p2.SetEmail("sally@rocket.com");
			Console.WriteLine(p2.GetEmail()); // Expect sally@rocket.com

			Person p3 = new Person();
			p3.SetName("Julie Jones");
			Console.WriteLine(p3.GetName()); // Expect Julie Jones
			p3.SetEmail("julie@rocket.com");
			Console.WriteLine(p3.GetEmail()); // Expect julie@rocket.com

			Console.WriteLine("\nTest out a list\n");

			List<Person> people = new List<Person>();
			people.Add(p1);
			people.Add(p2);
			people.Add(p3);

			Console.WriteLine(people[0].GetName()); // Expect Fred Johnson
			Console.WriteLine(people[1].GetName()); // Expect Sally Smith
			Console.WriteLine(people[2].GetName()); // Expect Julie Jones

			Console.WriteLine("\nTest out ToString()\n");

			// Let's give our Person class the ability to print itself
			Console.WriteLine(people[0]);  // Expect the ToString version of Fred
			Console.WriteLine(p1);         // Expect the ToString version of Fred
			string test = p1.ToString();   // This copies the result of ToString() into variable called test
			Console.WriteLine(test);

			// Let's loop through our list

			Console.WriteLine("\nTest regular for loop\n");
			for (int index = 0; index < people.Count; index++)
			{
				Person current = people[index];
				Console.WriteLine(current);
			}

			Console.WriteLine("\nTest foreach loop\n");
			foreach (Person next in people)
			{
				// Practice changing the members. You're changing the original instances!
				//next.SetName("HELLO");
				Console.WriteLine(next);
			}

			// Try changing members of the list items
			Console.WriteLine("\nTry changing the member of the first Person instance in the list.");
			people[0].SetName("Frederick Johnson");
			Console.WriteLine(p1.GetName());    // Expect to see Frederick Johnson because we changed the object itself, not a copy

			//
			//  Building a search mechanism
			//
			// Let's search the list for Sally Smith's email address
			//
			// First set up the variables:
			//    search: The name we're searching for
			//    found:  The actual instance that we located
			Console.WriteLine("\nLet's search the list\n");
			Person found = null;
			string search = "Sally Smith";

			// Now we'll loop through the list, checking each name
			// If we find a match, we'll save it away, and get out of the loop since we're done
			foreach (Person check in people)
			{
				//Console.WriteLine($"Testing {check.GetName()}"); // This is good for debugging to make sure our loop works
				if (check.GetName() == search)
				{
					// Console.WriteLine(check.GetEmail()); // For testing: Expect to see sally@rocket.com
					found = check;
					break; // Break out of the loop
				}
			}

			// Let's check if we actually found the one, and if so print it out. Otherwise print a "not found" message.
			if (found != null)
			{
				Console.WriteLine("Found it!");
				Console.WriteLine($"{found.GetName()} has email address {found.GetEmail()}");
			}
			else
			{
				Console.WriteLine($"That name {search} does not exist.");
			}
		}
	}
}
