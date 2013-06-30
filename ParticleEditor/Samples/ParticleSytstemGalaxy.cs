using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemGalaxy : ParticleSystem
    {
        public ParticleSytstemGalaxy()
        {
            // duration
            Duration = -1;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            /*Gravity = Point.Empty;*/

            // Gravity Mode: radial acceleration
            RadialAccel = 0;
            RadialAccelVar = 0;

            // Gravity Mode: speed of particles
            Speed = 60;
            SpeedVar = 10;

            // starting angle
            Angle = 90;
            AngleVar = 360;

            TangentialAccel = 80;
            TangentialAccelVar = 0;

            // emitter position
            /*PosVar = new Point(0, 0);*/

            // life of particles
            Life = 4;
            LifeVar = 1.0f;


            // size, in pixels
            StartSize = 37.0f;
            StartSizeVar = 10.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 200;
            EmissionRate = TotalParticles / Life;

            // color of particles
            StartColor = ToColor(0.12f, 0.25f, 0.76f, 1.0f);
            StartColorVar = ToColor(0.0f, 0.0f, 0.0f, 0.0f);

            EndColor = ToColor(0.0f, 0.0f, 0.0f, 1.0f);
            EndColorVar = ToColor(0.0f, 0.0f, 0.0f, 0.0f);



            // additive

            TexturePath = "fire.png";
        }
    }
}
