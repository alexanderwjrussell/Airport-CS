using NUnit.Framework;
using System;
namespace Airport_CS
{
	[TestFixture]
	public class AirportTest
	{
		Airport airport;

		[SetUp]
		public void SetUp() 
		{
			airport = new Airport();
		}

		[Test]
		public void Should_ReturnEmptyList_WhenInitialised()
		{
			Assert.That(airport.Planes, Is.Empty);
		}
	}
}
