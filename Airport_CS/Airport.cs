using System.Collections.Generic;

namespace Airport_CS
{
	public class Airport
	{
		public List<Plane> Planes { get; internal set; }

		public Airport()
		{
			Planes = new List<Plane>();
		}
	}
}