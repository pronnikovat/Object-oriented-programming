using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Venus : AstronomicalObject, Planet
    {
        private static Venus instance;
        public long SemiMajorAxis { get; set; }
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Venus()
        {
            name = "Venus";
            radius = 6052;
            mass = (int)(4.8675 * (10 ^ 24));
            density = 5.24;
            orbitVelocity = 126077;
            SemiMajorAxis = 108208930;
            DenseAtmosphere = true;
            AtmosphericPressure = 9300000;
            SurfaceGravity = 8.87;
        }
        public static Venus Instance()
        {
            if (instance == null)
                instance = new Venus();
            return instance;
        }
    }
}
