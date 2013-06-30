using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemModernArt : ParticleSystem
    {
        public ParticleSytstemModernArt()
        {

            TotalParticles = 1000;
            TexturePath = "fire.png";

            // duration
            Duration = -1;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            

            // Gravity Mode: radial acceleration
            RadialAccel = 70;
            RadialAccelVar = 10;

            // Gravity Mode: speed of particles
            Speed = 50;
            SpeedVar = 10;

            // starting angle
            Angle = 0;
            AngleVar = 360;

            TangentialAccel = 80;
            TangentialAccelVar = 0;

            // emitter position
            /*PosVar = new Point(0, 0);*/

            // life of particles
            Life = 2;
            LifeVar = 0.3f;

            //StartSpin = 0;
            //StartSpinVar = 0;

            //EndSpin = 0;
            //EndSpinVar = 2000;

            // size, in pixels
            StartSize = 1.0f;
            StartSizeVar = 1.0f;
            EndSize = 32;
            EndSizeVar = 8;


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
