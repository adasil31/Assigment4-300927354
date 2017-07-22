using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Alessandro da Silva Santos
 *  Date: 2017-07-20
 *  Description: Assignment 4 Abstract Class
 *  Version 0.6 - Implement has Habitable and implement has moon
 */

namespace Assigment4_300927354
{
    class Program
    {
        static void Main(string[] args)

        {
            //main created
            GiantPlanet giantPlanet = new GiantPlanet("Saturn have ", 116464, 5.6836, "Gas");
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth have ", 12742, 5.972, true);
            Console.WriteLine(terrestrialPlanet.ToString());

            WaitForAnyKey();

        }
        // public static WaitForAnyKey Created//
        public static void WaitForAnyKey()
        {
            Console.WriteLine("If you finish it press any key to close");
            Console.ReadKey();
        }
    }
}

