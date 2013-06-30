using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemSnow : ParticleSystem
    {
        public ParticleSytstemSnow()
        {
            // duration
            Duration = -1.0f;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            GravityY = -10;
            

            // Gravity Mode: radial acceleration
            RadialAccel = 0;
            RadialAccelVar = 1;

            // Gravity Mode: speed of particles
            Speed = 130;
            SpeedVar = 30;

            // starting angle
            Angle = -90;
            AngleVar = 5;

            TangentialAccel = 0;
            TangentialAccelVar = 1;

            // emitter position
            PosVarX = 240;
            

            // life of particles
            Life = 3;
            LifeVar = 1.0f;


            // size, in pixels
            StartSize = 10.0f;
            StartSizeVar = 5.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 700;
            EmissionRate = TotalParticles/Life;

            // color of particles
            StartColor = ToColor(0.9f, 0.9f, 0.9f, 1.0f);
            StartColorVar = ToColor(0.0f, 0.0f, 0.1f, 0.0f);

            EndColor = ToColor(1.0f, 1.0f, 1.0f, 0.0f);
            EndColorVar = ToColor(0.0f, 0.0f, 0.0f, 0.0f);



            // additive

            TexturePath = "snow.png";
        }
    }
}
