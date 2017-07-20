using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment4_300927354
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;

        //this is the constructor.
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        public bool HasMoons
        {
            //implement has moon
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool Habitable
        {
            //implement has Habitable
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}