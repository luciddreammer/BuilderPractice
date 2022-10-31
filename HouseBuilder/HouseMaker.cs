using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    public static class HouseMaker
    {
        public static House MakeMeAHouse(string typeOfWalls, bool IsFirstFloor, bool IsBasement, bool IsGroundFloor)
        {
            var director = new Director();
            var woodenHouseBuilder = new WoodenHouseBuilder();
            var concreteHouseBuilder = new ConcreteHouseBuilder();
            var newHouse = new House();

            if (typeOfWalls == TypeOfWalls.Wooden)
            {
                director.Builder(woodenHouseBuilder);
                if (IsFirstFloor == true)
                {
                    director.PremiumHouse();
                }
                else if (IsBasement == true)
                {
                    director.GroundHouseWithBasement();
                }
                else if (IsBasement == false)
                {
                    director.GroundHouse();
                }
                newHouse = woodenHouseBuilder.GetHouse();
            }else if(typeOfWalls == TypeOfWalls.Concrete)
            {
                director.Builder(concreteHouseBuilder);
                if (IsFirstFloor == true)
                {
                    director.PremiumHouse();
                }
                else if (IsBasement == true)
                {
                    director.GroundHouseWithBasement();
                }
                else if (IsBasement == false)
                {
                    director.GroundHouse();
                }
                newHouse = concreteHouseBuilder.GetHouse();
            }
            return newHouse;
        }
    }
}
