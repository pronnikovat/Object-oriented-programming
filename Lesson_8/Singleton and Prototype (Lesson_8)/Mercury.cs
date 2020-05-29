using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Mercury : AstronomicalObject, Planet
    {
        private static Mercury instance;
        public long SemiMajorAxis { get; set; }
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Mercury()
        {
            name = "Mercury";
            radius = 2440;
            mass = (int)(3.33022 * (10 ^ 23));
            density = 5.427;
            orbitVelocity = 172341;
            SemiMajorAxis = 57909227;
            DenseAtmosphere = false;
            AtmosphericPressure = 0;
            SurfaceGravity = 3.7;
        }
        public static Mercury Instance()
        {
            if (instance == null)
                instance = new Mercury();
            return instance;
        }
    }
}
