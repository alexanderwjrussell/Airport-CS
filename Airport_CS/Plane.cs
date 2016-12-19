using System;

namespace Airport_CS
{
	public class Plane
	{
		public bool Flying { get; set;}

		public void Land(Airport airport)
		{
			if (!Flying)
				throw new Exception("Plane must be flying in order to land");

			if (airport.Planes.Count == airport.Capacity)
				throw new Exception("Airport is over capacity");

			airport.Planes.Add(this);
		}

		public void TakeOff(Airport airport)
		{
			airport.Planes.Remove(this);
			Flying = true;
		}
	}	
}