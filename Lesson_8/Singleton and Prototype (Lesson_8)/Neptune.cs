using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Neptune : AstronomicalObject, Planet
    {
        private static Neptune instance;
        public long SemiMajorAxis { get; set; }
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Neptune()
        {
            name = "Neptune";
            radius = 24764;
            mass = (int)(1.0243 * (10 ^ 26));
            density = 1.76;
            orbitVelocity = 19720;
            SemiMajorAxis = 4498252900;
            DenseAtmosphere = false;
            AtmosphericPressure = 100000;
            SurfaceGravity = 10.71;
        }
        public static Neptune Instance()
        {
            if (instance == null)
                instance = new Neptune();
            return instance;
        }
    }
}
