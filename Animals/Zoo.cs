using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
	class Zoo
	{
		public string Location { get; set; }

		public readonly int Area;

		public readonly int AreaOfTheAnimals;

		public readonly int AreaForVisiters;

		public static DateTime TimeOpen = DateTime.Parse("09:00");
		public static DateTime TimeClose = DateTime.Parse("20:00");

		public Zoo(string location, int area, int areaOfTheAnimals)
		{
			Location = location;
			Area = area;
			AreaOfTheAnimals = areaOfTheAnimals;
			if (areaOfTheAnimals < area && areaOfTheAnimals > 0)
			{
				AreaForVisiters = area - areaOfTheAnimals;
			}
			else
				throw new Exception("Error from area");
		}

		public override string ToString()
		{
			return $"Location = {Location}\n" +
				   $"Area = {Area}\n" +
				   $"AreaOfTheAnimals = {AreaOfTheAnimals}m^2\n" +
				   $"AreaForVisiters = {AreaForVisiters}m^2\n" +
				   $"Time Open = {TimeOpen}\n" +
				   $"Time Close = {TimeClose}\n";
		}
	}
}
