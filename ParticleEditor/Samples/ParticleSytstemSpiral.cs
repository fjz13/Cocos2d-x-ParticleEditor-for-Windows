using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemSpiral : ParticleSystem
    {
        public ParticleSytstemSpiral()
        {
            // duration
            Duration = -1;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            /*Gravity = new Point(0,0);*/

            // Gravity Mode: radial acceleration
            RadialAccel = -380;
            RadialAccelVar = 0;

            // Gravity Mode: speed of particles
            Speed = 150;
            SpeedVar = 0;

            // starting angle
            Angle = 90;
            AngleVar = 0;

            TangentialAccel = 45;
            TangentialAccelVar = 0;

            // emitter position
            /*PosVar = new Point(0, 0);*/

            // life of particles
            Life = 12;
            LifeVar = 0.0f;


            // size, in pixels
            StartSize = 20.0f;
            StartSizeVar = 0.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 500;
            EmissionRate = TotalParticles / Life;

            // color of particles
            StartColor = ToColor(0.5f, 0.5f, 0.5f, 1.0f);
            StartColorVar = ToColor(0.5f, 0.5f, 0.5f, 0.0f);

            EndColor = ToColor(0.5f, 0.5f, 0.5f, 1.0f);
            EndColorVar = ToColor(0.5f, 0.5f, 0.5f, 0.0f);



            // additive

            TexturePath = "fire.png";
        }
    }
}
