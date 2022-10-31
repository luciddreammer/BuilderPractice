using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    public class Director
    {
        private IBuilder _builder;
        public void Builder(IBuilder builder)
        {
            _builder = builder;
        }

        public void GroundHouse()
        {
            this._builder.BuildGroundFloor();
        }

        public void GroundHouseWithBasement()
        {
            this._builder.BuildGroundFloor();
            this._builder.DigBasement();
        }

        public void PremiumHouse()
        {
            this._builder.BuildGroundFloor();
            this._builder.DigBasement();
            this._builder.AddFirstFloor();
            this._builder.AddAttic();
        }
    }
}
