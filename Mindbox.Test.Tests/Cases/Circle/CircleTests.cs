using System;
using NUnit.Framework;

namespace Mindbox.Test.Tests.Cases.Circle
{
    public class CircleTests
    {
        [Test]
        [TestCase(4f)]
        [TestCase(1f)]
        [TestCase(16f)]
        [TestCase(10f)]
        [TestCase(64.4f)]
        [TestCase(212.3f)]
        public void Circle_Exhibition_Test(float radius)
        {
            Models.Circle circle = new Models.Circle(radius);
            
            Console.WriteLine(circle);
        }
    }
}