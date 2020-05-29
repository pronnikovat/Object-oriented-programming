using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Jupiter : AstronomicalObject, Planet
    {
        private static Jupiter instance;
        public long SemiMajorAxis { get; set; }
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Jupiter()
        {
            name = "Jupiter";
            radius = 71492;
            mass = (int)(1.8986 * (10 ^ 27));
            density = 1.33;
            orbitVelocity = 47052;
            SemiMajorAxis = 778340817;
            DenseAtmosphere = false;
            AtmosphericPressure = 220000;
            SurfaceGravity = 24.79;
        }
        public static Jupiter Instance()
        {
            if (instance == null)
                instance = new Jupiter();
            return instance;
        }
    }
}
