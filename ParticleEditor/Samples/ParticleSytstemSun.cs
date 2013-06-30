using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ParticleEditor.Samples
{
    class ParticleSytstemSun : ParticleSystem
    {
        public ParticleSytstemSun()
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
            Speed = 20;
            SpeedVar = 5;

            // starting angle
            Angle = 90;
            AngleVar = 360;

            // emitter position
            /*PosVar = new Point(0, 0);*/

            // life of particles
            Life = 1.0f;
            LifeVar = 0.5f;


            // size, in pixels
            StartSize = 30.0f;
            StartSizeVar = 10.0f;
            EndSize = -1;

            // emits per frame
            TotalParticles = 350;
            EmissionRate = TotalParticles / Life;

            // color of particles
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
