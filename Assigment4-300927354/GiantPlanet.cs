using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment4_300927354
{
    /// <summary>
    /// This is the Giant Planet class
    /// </summary>
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        //This is the constructor
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
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
    }
}


