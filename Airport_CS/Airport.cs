using System.Collections.Generic;

namespace Airport_CS
{
	public class Airport
	{
		public List<Plane> Planes { get; internal set; }
		public int Capacity { get; set; }

		public Airport()
		{
			Planes = new List<Plane>();
			Capacity = 5;
		}
	}
}