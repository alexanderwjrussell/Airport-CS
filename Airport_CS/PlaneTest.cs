using NUnit.Framework;
using System;
namespace Airport_CS
{
	[TestFixture]
	public class PlaneTest
	{
		Plane plane;
		Airport airport;

		[SetUp]
		public void SetUp()
		{
			plane = new Plane();
			airport = new Airport();
		}

		[Test]
		public void Should_Initialise_WithFlyingPropertyFalse()
		{
			Assert.That(plane.Flying, Is.False);
		}

		[Test]
		public void Should_AllowAPlaneToLand()
		{
			plane.Land(airport);
			Assert.That(airport.Planes.Count, Is.EqualTo(1));
		}
	}
}