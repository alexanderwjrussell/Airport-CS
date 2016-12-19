using System;

namespace Airport_CS
{
	public class Plane
	{
		public bool Flying { get; private set;}

		public void Land(Airport airport)
		{
			airport.Planes.Add(this);
		}
	}
}