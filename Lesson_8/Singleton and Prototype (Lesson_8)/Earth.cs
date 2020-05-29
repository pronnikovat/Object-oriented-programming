using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Earth : AstronomicalObject, Planet
    {
        private static Earth instance;
        public long SemiMajorAxis { get; set; }
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Earth()
        {
            name = "Earth";
            radius = 6378;
            mass = (int)(5.9726 * (10 ^ 24));
            density = 5.515;
            orbitVelocity = 107229;
            SemiMajorAxis = 149598261;
            DenseAtmosphere = true;
            AtmosphericPressure = 101325000;
            SurfaceGravity = 9.780327;
        }
        public static Earth Instance()
        {
            if (instance == null)
                instance = new Earth();
            return instance;
        }
    }
}
