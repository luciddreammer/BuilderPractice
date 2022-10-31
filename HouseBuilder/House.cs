using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    public class House
    {
        public string TypeOfWalls = "No walls";
        public bool IsBasement = false;
        public bool IsGroundFloor = false;
        public bool IsFirstFloor = false;
        public bool IsAttic = false;

        public void PresentThisHouse()
        {
            Console.WriteLine("This is house with:\n{0} type of walls.\nDoes it have basement? {1}\nDoes it have firstFloor? {2}\nDoes it have attic? {3}\nBut does it have a ground floor?! {4}", TypeOfWalls, IsBasement, IsFirstFloor, IsAttic, IsGroundFloor);
        }
    }
}
