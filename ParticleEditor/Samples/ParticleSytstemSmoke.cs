using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemSmoke : ParticleSystem
    {
        public ParticleSytstemSmoke()
        {
            // duration
            Duration = -1.0f;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            /*Gravity = new Point(0,0);*/

            // Gravity Mode: radial acceleration
            RadialAccel = 0;
            RadialAccelVar = 0;

            // Gravity Mode: speed of particles
            Speed = 25;
            SpeedVar = 10;

            // starting angle
            Angle = 90;
            AngleVar = 5;

            TangentialAccel = 0;
            TangentialAccelVar = 0;

            // emitter position
            PosVarX = 20;

            

            // life of particles
            Life = 4;
            LifeVar = 1.0f;


            // size, in pixels
            StartSize = 60.0f;
            StartSizeVar = 10.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 200;
            EmissionRate = TotalParticles / Life;

            // color of particles
            StartColor = ToColor(0.8f, 0.8f, 0.8f, 1.0f);
            StartColorVar = ToColor(0.02f, 0.02f, 0.02f, 0.0f);

            EndColor = ToColor(0.0f, 0.0f, 0.0f, 1.0f);
            EndColorVar = ToColor(0.0f, 0.0f, 0.0f, 0.0f);



            // additive

            TexturePath = "fire.png";
        }
    }
}
