using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemRadiusMode1 : ParticleSystem
    {
        public ParticleSytstemRadiusMode1()
        {
            // duration
            Duration = -1;

            // Gravity Mode
            Mode = EmiiterMode.Radius;

            StartRadius = 0;
            StartRadiusVar = 0;
            EndRadius = 160;
            EndRadiusVar = 0;

            RotatePerSecond = 180;
            RotatePerSecondVar = 0;


            // starting angle
            Angle = 90;
            AngleVar = 0;

            // emitter position
            //PosVar = new Point(0, 0);

            // life of particles
            Life = 5;
            LifeVar = 0.0f;


            StartSpin = 0;
            StartSpinVar = 0;

            EndSpin = 0;
            EndSpinVar = 0;

            // size, in pixels
            StartSize = 32.0f;
            StartSizeVar = 0.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 250;
            EmissionRate = TotalParticles / Life;

            // color of particles
            StartColor = ToColor(0.5f, 0.5f, 0.5f, 1.0f);
            StartColorVar = ToColor(0.5f, 0.5f, 0.5f, 0.5f);

            EndColor = ToColor(0.1f, 0.1f, 0.1f, 0.2f);
            EndColorVar = ToColor(0.1f, 0.1f, 0.1f, 0.2f);



            // additive

            TexturePath = "stars-grayscale.png";
        }
    }
}
