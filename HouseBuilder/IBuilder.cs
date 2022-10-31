using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    public interface IBuilder
    {
        void DigBasement();
        void BuildGroundFloor();
        void AddFirstFloor();
        void AddAttic();
    }
}
