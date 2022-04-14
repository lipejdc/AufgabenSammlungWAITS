using Aufgabe102;
using NUnit.Framework;

namespace Aufgabe102___Der_Ball_Test
{
    public class DerBall_Tests
    {

        private Ball _testBall;
        private Farben _color;


        [SetUp]
        public void Setup()
        {
            _testBall = new Ball(Farben.Red, new Punkt3D(80, 90, 100));
            _color = new Farben();
        }

        [TestCase()]
        public void AddVector_Test(int x, int y, int z)
        {
            //var result = _testBall.AddVector(x, y, z);
            //int expected = 
            //Assert.AreEqual();
        }

        [TestCase()]
        public void AddVector_Test2(Punkt3D pointToAdd)
        {

        }

        [TestCase()]
        public void SetPosition_Test(int x, int y, int z)
        {

        }

        [TestCase()]
        public void SetPosition_Test2(Punkt3D pointToSet)
        {
            if (pointToSet.X =)
            _testBall.Position.X = pointToSet.X;
            _testBall.Position.Y = pointToSet.Y;
            _testBall.Position.Z = pointToSet.Z;

            Assert.AreEqual(pointToSet.X, _testBall.Position.X);
            Assert.AreEqual(pointToSet.Y, _testBall.Position.Y);
            Assert.AreEqual(pointToSet.Z, _testBall.Position.Z);
        }

        [TestCase(Farben.Red)]
        [TestCase(Farben.Green)]
        [TestCase(Farben.Yellow)]
        public void SetColor_Test(Farben colorToSet)
        {

            if (colorToSet == Farben.Red)
            {
                _testBall.Farbe = Farben.Red;
            }
            else if (colorToSet == Farben.Green)
            {
                _testBall.Farbe = Farben.Green;
            }
            else
            {
                _testBall.Farbe = Farben.Yellow;
            }
            Assert.AreEqual(_testBall.Farbe, colorToSet);
        }

    }
}