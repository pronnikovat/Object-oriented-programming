using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Saturn : AstronomicalObject, Planet
    {
        private static Saturn instance;
        public long SemiMajorAxis { get; set; }
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Saturn()
        {
            name = "Saturn";
            radius = 60268;
            mass = (int)(5.6846 * (10 ^ 26));
            density = 0.69;
            orbitVelocity = 34884;
            SemiMajorAxis = 1426666414;
            DenseAtmosphere = false;
            AtmosphericPressure = 140000;
            SurfaceGravity = 10.4;
        }
        public static Saturn Instance()
        {
            if (instance == null)
                instance = new Saturn();
            return instance;
        }
    }
}
