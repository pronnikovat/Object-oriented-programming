using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Mars : AstronomicalObject, Planet
    {
        private static Mars instance;
        public long SemiMajorAxis { get; set; }
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Mars()
        {
            name = "Mars";
            radius = 3397;
            mass = (int)(6.4171 * (10 ^ 23));
            density = 3.94;
            orbitVelocity = 86871;
            SemiMajorAxis = 227936640;
            DenseAtmosphere = false;
            AtmosphericPressure = 636;
            SurfaceGravity = 3.7117;
        }
        public static Mars Instance()
        {
            if (instance == null)
                instance = new Mars();
            return instance;
        }
    }
}
