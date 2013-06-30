using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemRain : ParticleSystem
    {
        public ParticleSytstemRain()
        {
            // duration
            Duration = -1.0f;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            GravityX = 10;
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
            Life = 4.5f;
            LifeVar = 0.0f;


            // size, in pixels
            StartSize = 4.0f;
            StartSizeVar = 2.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 1000;
            EmissionRate = 20;

            // color of particles
            StartColor = ToColor(0.7f, 0.8f, 1.0f, 1.0f);
            StartColorVar = ToColor(0.0f, 0.0f, 0.0f, 0.0f);

            EndColor = ToColor(0.7f, 0.8f, 1.0f, 0.5f);
            EndColorVar = ToColor(0.0f, 0.0f, 0.0f, 0.0f);



            // additive

            TexturePath = "fire.png";
        }
    }
}
