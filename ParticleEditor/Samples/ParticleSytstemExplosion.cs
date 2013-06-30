using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemExplosion : ParticleSystem
    {
        public ParticleSytstemExplosion()
        {
            // duration
            Duration = 0.1f;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            /*Gravity = new Point(0,0);*/

            // Gravity Mode: radial acceleration
            RadialAccel = 0;
            RadialAccelVar = 0;

            // Gravity Mode: speed of particles
            Speed = 70;
            SpeedVar = 40;

            // starting angle
            Angle = 90;
            AngleVar = 360;

            TangentialAccel = 0;
            TangentialAccelVar = 0;

            // emitter position
            //PosVar = new Point(0, 0);

            // life of particles
            Life = 5;
            LifeVar = 2.0f;


            // size, in pixels
            StartSize = 15.0f;
            StartSizeVar = 10.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 700;
            EmissionRate = TotalParticles / Duration;

            // color of particles
            StartColor = ToColor(0.7f, 0.1f, 0.2f, 1.0f);
            StartColorVar = ToColor(0.5f, 0.5f, 0.5f, 0.0f);

            EndColor = ToColor(0.5f, 0.5f, 0.5f, 0.0f);
            EndColorVar = ToColor(0.5f, 0.5f, 0.5f, 0.0f);



            // additive

            TexturePath = "stars.png";
        }
    }
}
