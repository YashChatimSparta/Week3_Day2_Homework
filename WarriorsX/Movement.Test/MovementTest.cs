using System;
using NUnit.Framework;
using WarriorsX;

// namespace name should be different from Class name
namespace Movements.Test
{
    [TestFixture]
    public class MovementTest
    {
        Movement movement;

        [SetUp]
        public void SetupMethod()
        {
            movement = new Movement();
        }

        [Test]
        public void TestMoveRight()
        {
            Assert.AreEqual(10, movement.moveRight());
        }

        [Test]
        public void TestMoveLeft()
        {
            Assert.AreEqual(-10, movement.moveLeft());
        }

        [Test]
        public void TestJump()
        {
            Assert.AreEqual(10, movement.jump());
        }

        [Test]
        public void TestDuck()
        {
            Assert.AreEqual(-10, movement.duck());
        }
    }
}
