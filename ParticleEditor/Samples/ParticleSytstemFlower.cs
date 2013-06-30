using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemFlower : ParticleSystem
    {
        public ParticleSytstemFlower()
        {
            // duration
            Duration = -1;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            /*Gravity = Point.Empty;*/

            // Gravity Mode: radial acceleration
            RadialAccel = -60;
            RadialAccelVar = 0;

            // Gravity Mode: speed of particles
            Speed = 80;
            SpeedVar = 10;

            // starting angle
            Angle = 90;
            AngleVar = 360;

            TangentialAccel = 15;
            TangentialAccelVar = 0;

            // emitter position
            //PosVar = new Point(0, 0);

            // life of particles
            Life = 4;
            LifeVar = 1.0f;


            // size, in pixels
            StartSize = 30.0f;
            StartSizeVar = 10.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 250;
            EmissionRate = TotalParticles / Life;

            // color of particles
            // color of particles
            StartColor = ToColor(0.5f, 0.5f, 0.5f, 1.0f);
            StartColorVar = ToColor(0.5f, 0.5f, 0.5f, 0.5f);

            EndColor = ToColor(0.0f, 0.0f, 0.0f, 1.0f);
            EndColorVar = ToColor(0.0f, 0.0f, 0.0f, 0.0f);



            // additive

            TexturePath = "stars.png";
        }
    }
}
