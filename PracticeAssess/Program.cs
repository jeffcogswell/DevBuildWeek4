using System;
using System.Collections.Generic;

namespace PracticeAssess
{

	class Pants
	{
		private string pStyle;
		private List<int> pSizes;

		public Pants(string _Style, List<int> _Sizes)
		{
			pStyle = _Style;
			pSizes = _Sizes;
		}

		public string GetStyle()
		{
			return pStyle;
		}

		public bool IsAvailable(int find)
		{
			if (pSizes.Contains(find))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public override string ToString()
		{
			return $"{pStyle} {String.Join(',', pSizes)}";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

			List<Pants> Inventory = new List<Pants>();

			List<int> firstSizes = new List<int>() { 10, 12, 14, 16 };
			Pants first = new Pants("Latest", firstSizes);
			Inventory.Add(first);

			List<int> secondSizes = new List<int>() { 8, 10, 12 };
			Pants second = new Pants("Walmart", secondSizes);
			Inventory.Add(second);

			Inventory.Remove(first);
			foreach (Pants item in Inventory)
			{
				//if (item.GetStyle() == "Walmart")
				//{
					Console.WriteLine(item);
				//}
			}



		}
	}
}
