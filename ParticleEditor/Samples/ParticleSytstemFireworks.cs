using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ParticleEditor.Samples
{
    class ParticleSytstemFireworks : ParticleSystem
    {
        public ParticleSytstemFireworks()
        {
            // duration
            Duration = -1;

            // Gravity Mode
            Mode = EmiiterMode.Gravity;

            // Gravity Mode: gravity
            GravityY = -90;
            

            // Gravity Mode: radial acceleration
            RadialAccel = 180;
            RadialAccelVar = 50;

            // Gravity Mode: speed of particles
            Speed = 60;
            SpeedVar = 20;

            // starting angle
            Angle = 90;
            AngleVar = 20;

            // emitter position
            //PosVar = new Point(40, 20);

            // life of particles
            Life = 3.5f;
            LifeVar = 1.0f;


            // size, in pixels
            StartSize = 8.0f;
            StartSizeVar = 2.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 1500;
            EmissionRate = TotalParticles / Life;

            // color of particles
            StartColor = ToColor(0.5f, 0.5f, 0.5f, 1.0f);
            StartColorVar = ToColor(0.5f, 0.5f, 0.5f, 0.1f);

            EndColor = ToColor(0.1f, 0.1f, 0.1f, 0.2f);
            EndColorVar = ToColor(0.1f, 0.1f, 0.1f, 0.2f);



            // additive

            TexturePath = "stars.png";
        }
    }
}
