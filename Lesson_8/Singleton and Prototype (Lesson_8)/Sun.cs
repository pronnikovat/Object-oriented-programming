using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lesson_8
{
    class Sun : AstronomicalObject, Star
    {
        private static Sun instance;
        public SpectralClass SpectralClass { get; set; }
        public LuminosityClass LuminosityClass { get; set; }
        public List<AstronomicalObject> Planets { get; set; }

        protected Sun()
        {
            name = "Sun";
            radius = 695500;
            mass = (int)(1.9885 * (10 ^ 30));
            density = 1.409;
            orbitVelocity = (int)(2.2 * (10 ^ 5));
            SpectralClass = SpectralClass.G;
            LuminosityClass = LuminosityClass.V;
            Planets = new List<AstronomicalObject>()
            {
                Mercury.Instance(),
                Venus.Instance(),
                Earth.Instance(),
                Mars.Instance(),
                Jupiter.Instance(),
                Saturn.Instance(),
                Uranus.Instance(),
                Neptune.Instance()
            };
        }

        public static Sun Instance()
        {
            if (instance == null)
                instance = new Sun();
            return instance;
        }
    }
}
