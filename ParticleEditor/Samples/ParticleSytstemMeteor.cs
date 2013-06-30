using System.Drawing;

namespace ParticleEditor.Samples
{
    public class ParticleSytstemMeteor : ParticleSystem
    {
        public ParticleSytstemMeteor()
        {
            // duration
            Duration = -1;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            GravityX = -200;
            GravityY = 200;

            

            // Gravity Mode: radial acceleration
            RadialAccel = 0;
            RadialAccelVar = 0;

            // Gravity Mode: speed of particles
            Speed = 15;
            SpeedVar = 5;

            // starting angle
            Angle = 90;
            AngleVar = 360;

            TangentialAccel = 0;
            TangentialAccelVar = 0;

            // emitter position
            /*PosVar = new Point(0, 0);*/

            // life of particles
            Life = 2;
            LifeVar = 1.0f;


            // size, in pixels
            StartSize = 60.0f;
            StartSizeVar = 10.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 150;
            EmissionRate = TotalParticles / Life;

            // color of particles
            // color of particles
            StartColor = ToColor(0.2f, 0.4f, 0.7f, 1.0f);
            StartColorVar = ToColor(0.0f, 0.0f, 0.2f, 0.1f);

            EndColor = ToColor(0.0f, 0.0f, 0.0f, 1.0f);
            EndColorVar = ToColor(0.0f, 0.0f, 0.0f, 0.0f);



            // additive

            TexturePath = "fire.png";
        }
    }
}
