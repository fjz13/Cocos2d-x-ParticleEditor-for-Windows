using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemBigFlower : ParticleSystem
    {
        public ParticleSytstemBigFlower()
        {
            TotalParticles = 50;
            TexturePath = "stars.png";

            // duration
            Duration = -1;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            

            // Gravity Mode: radial acceleration
            RadialAccel = -120;
            RadialAccelVar = 0;

            // Gravity Mode: speed of particles
            Speed = 160;
            SpeedVar = 20;

            // starting angle
            Angle = 90;
            AngleVar = 360;

            TangentialAccel = 30;
            TangentialAccelVar = 0;

            // emitter position
            /*PosVar = new Point(0, 0);*/

            // life of particles
            Life = 4;
            LifeVar = 1.0f;

            StartSpin = 0;
            StartSpinVar = 0;

            EndSpin = 0;
            EndSpinVar = 0;




            // size, in pixels
            StartSize = 80.0f;
            StartSizeVar = 40.0f;
            EndSize = -1;

            // emits per frame
            EmissionRate = TotalParticles / Life;

            // color of particles
            StartColor = ToColor(0.5f, 0.5f, 0.5f, 1.0f);
            StartColorVar = ToColor(0.5f, 0.5f, 0.5f, 1.0f);

            EndColor = ToColor(0.1f, 0.1f, 0.1f, 0.2f);
            EndColorVar = ToColor(0.1f, 0.1f, 0.1f, 0.2f);


        }
    }
}
