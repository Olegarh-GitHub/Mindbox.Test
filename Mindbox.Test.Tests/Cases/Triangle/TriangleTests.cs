using System;
using NUnit.Framework;

namespace Mindbox.Test.Tests.Cases.Triangle
{
    public class TriangleTests
    {
        [Test]
        [TestCase(3f, 4f, 5f)]
        [TestCase(10f, 17f, 29f)]
        [TestCase(1f, 2f, 27f)]
        [TestCase(10f, 30f, 62f)]
        public void IsThisTriangleExists_Test(float a, float b, float c)
        {
            Assert.DoesNotThrow(delegate
            {
                Models.Triangle triangle = new Models.Triangle(a, b, c);
                
                Console.WriteLine(triangle);
            });
        }

        [Test]
        [TestCase(3f, 4f, 5f)]
        [TestCase(10f, 10f, 10f)]
        [TestCase(6f, 6f, 3f)]
        [TestCase(6f, 10f, 12f)]
        public void Triangle_Exhibition_Test(float a, float b, float c)
        {
            Models.Triangle triangle = new Models.Triangle(a, b, c);
            
            Console.WriteLine(triangle);
        }
    }
}