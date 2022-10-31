using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    public class ConcreteHouseBuilder : IBuilder
    {
        private House newHouse = new House();

        public ConcreteHouseBuilder()
        {
            this.Reset();
            this.newHouse.TypeOfWalls = "concrete";
        }

        public void Reset()
        {
            this.newHouse = new House();
        }

        public void AddFirstFloor()
        {
            this.newHouse.IsFirstFloor = true;
        }

        public void AddAttic()
        {
            this.newHouse.IsAttic = true;
        }

        public void BuildGroundFloor()
        {
            this.newHouse.IsGroundFloor = true;
        }

        public void DigBasement()
        {
            this.newHouse.IsBasement = true;
        }

        public House GetHouse()
        {
            var result = this.newHouse;
            this.Reset();

            return result;
        }
    }
}
