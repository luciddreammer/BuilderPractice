using HouseBuilder;

namespace HouseBuilderTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WoodenPremiumHouseTest()
        {
            //Arrange
            var director = new Director();
            var woodenHouseBuilder = new WoodenHouseBuilder();

            //Act
            var newHouse = HouseMaker.MakeMeAHouse(TypeOfWalls.Wooden, true, true, true);

            //Assert
            Assert.AreEqual(TypeOfWalls.Wooden, newHouse.TypeOfWalls, "Walls are not wooden");
            Assert.AreEqual(true, newHouse.IsFirstFloor, "It's not premium house");
        }

        [TestMethod]
        public void WoodenHouseWithBasementTest()
        {
            //Arrange
            var director = new Director();
            var woodenHouseBuilder = new WoodenHouseBuilder();

            //Act
            var newHouse = HouseMaker.MakeMeAHouse(TypeOfWalls.Wooden, false, true, true);

            //Assert
            Assert.AreEqual(TypeOfWalls.Wooden, newHouse.TypeOfWalls, "Walls are not wooden");
            Assert.AreEqual(false, newHouse.IsFirstFloor, "It's premium house");
            Assert.AreEqual(true, newHouse.IsBasement, "It don't have basement");
        }

        [TestMethod]
        public void ConcretePremiumHouseTest()
        {
            //Arrange
            var director = new Director();
            var concreteHouseBuilder = new ConcreteHouseBuilder();

            //Act
            var newHouse = HouseMaker.MakeMeAHouse(TypeOfWalls.Concrete, true, true, true);

            //Assert
            Assert.AreEqual(TypeOfWalls.Concrete, newHouse.TypeOfWalls, "Walls are not Concrete");
            Assert.AreEqual(true, newHouse.IsFirstFloor, "It's not premium house");
        }

        [TestMethod]
        public void ConcreteHouseWithBasementTest()
        {
            //Arrange
            var director = new Director();
            var concreteHouseBuilder = new ConcreteHouseBuilder();

            //Act
            var newHouse = HouseMaker.MakeMeAHouse(TypeOfWalls.Concrete, false, true, true);

            //Assert
            Assert.AreEqual(TypeOfWalls.Concrete, newHouse.TypeOfWalls, "Walls are not COncrete");
            Assert.AreEqual(false, newHouse.IsFirstFloor, "It's premium house");
            Assert.AreEqual(true, newHouse.IsBasement, "It don't have basement");
        }
    }
}