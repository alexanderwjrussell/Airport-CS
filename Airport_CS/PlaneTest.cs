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
		public void Should_ChangeFlyingState_WhenPlaneTakesOff()
		{
			airport.Planes.Add(plane);
			plane.TakeOff(airport);
			Assert.That(plane.Flying, Is.True);
		}

		[Test]
		public void Should_OnlyAllowFlyingPlanesToLand()
		{
			Assert.Throws<Exception>(() => plane.Land(airport));
		}

		[Test]
		public void Should_AllowAPlaneToLand()
		{
			plane.Flying = true;
			plane.Land(airport);
			Assert.That(airport.Planes.Count, Is.EqualTo(1));
		}

		[Test]
		public void Should_NotAllowPlanesToLand_WhenAirportIsFull()
		{
			var plane1 = new Plane { Flying = true };
			var plane2 = new Plane { Flying = true };
			var plane3 = new Plane { Flying = true };
			var plane4 = new Plane { Flying = true };
			var plane5 = new Plane { Flying = true };		
			var plane6 = new Plane { Flying = true };

			plane1.Land(airport);
			plane2.Land(airport);
			plane3.Land(airport);
			plane4.Land(airport);
			plane5.Land(airport);

			Assert.Throws<Exception>(() => plane6.Land(airport));
		}
	}
}