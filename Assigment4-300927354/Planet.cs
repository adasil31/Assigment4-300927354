using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment4_300927354
{
    /// <summary>
    /// planet class abstract
    /// </summary>
    public abstract class Planet
    {
        // variable declare first part
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;
        // Declare public propriety
        public double Diameter
        {
            // get because is ready only
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            //this properties is read only
            get
            {
                return this._name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }

        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }
        //Constructor created
        public Planet (string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }
        // to string created (correction of to string)
        public override string ToString()

        { string outputString = "";
            outputString += "===========================================================\n";
            outputString += "Name: " + this.Name + "\n";
            outputString += "Diameter: " + this.Diameter + "\n";
            outputString += "Mass: " + this.Mass + "\n";
            outputString += "===========================================================\n";
            return outputString;

        }

    }

}

