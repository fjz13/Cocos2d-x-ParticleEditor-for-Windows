using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemFire : ParticleSystem
    {
        public ParticleSytstemFire()
        {
            // duration
            Duration = -1;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            

            // Gravity Mode: radial acceleration
            RadialAccel = 0;
            RadialAccelVar = 0;

            // Gravity Mode: speed of particles
            Speed = 60;
            SpeedVar = 20;

            // starting angle
            Angle = 90;
            AngleVar = 10;

            // emitter position
            PosVarX = 40;
            PosVarY = 20;
            

            // life of particles
            Life = 3;
            LifeVar = 0.25f;


            // size, in pixels
            StartSize = 54.0f;
            StartSizeVar = 10.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 250;
            EmissionRate = TotalParticles / Life;

            // color of particles
            StartColor = ToColor(0.76f, 0.25f, 0.12f, 1.0f);
            StartColorVar = ToColor(0.0f, 0.0f, 0.0f, 0.0f);

            EndColor = ToColor(0.0f, 0.0f, 0.0f, 1.0f);
            EndColorVar = ToColor(0.0f, 0.0f, 0.0f, 0.0f);



            // additive

            TexturePath = "fire.png";
        }
    }
}
