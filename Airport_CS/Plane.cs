using System;

namespace Airport_CS
{
	public class Plane
	{
		public void Land(Airport airport)
		{
			airport.Planes.Add(this);
		}
	}
}