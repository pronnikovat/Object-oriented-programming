using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Uranus : AstronomicalObject, Planet
    {
        private static Uranus instance;
        public long SemiMajorAxis { get; set; }
        public bool DenseAtmosphere { get; set; }
        public int AtmosphericPressure { get; set; }
        public double SurfaceGravity { get; set; }

        protected Uranus()
        {
            name = "Uranus";
            radius = 25559;
            mass = (int)(8.6813 * (10 ^ 235);
            density = 1.3;
            orbitVelocity = 24607;
            SemiMajorAxis = 2870972200;
            DenseAtmosphere = false;
            AtmosphericPressure = 100000;
            SurfaceGravity = 8.43;
        }
        public static Uranus Instance()
        {
            if (instance == null)
                instance = new Uranus();
            return instance;
        }
    }
}
