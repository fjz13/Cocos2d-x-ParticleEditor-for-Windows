using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedusaSimulator;
using ParticleEditor.Samples;

namespace ParticleEditor
{
    public partial class ParticleEditorForm : Form
    {
        public delegate bool MInitializeApplication(int hwnd);
        public delegate bool MGameCleanUp();
        public delegate bool MGameLoop(float interval);


        public delegate bool MParticleChanged(float scale, bool isBackgroundMove, float angle, float angleVar, int destBlendFunc, int srcBlendFunc, float duration, float emissionRate, int emiiterMode,
        byte endColorR, byte endColorG, byte endColorB, byte endColorA,
        byte endColorVarR, byte endColorVarG, byte endColorVarB, byte endColorVarA,
        float endRadius, float endRadiusVar,
        float endSize, float endSizeVar,
        float endSpin, float endSpinVar,
        float gravityX, float gravityY,
        bool isAutoRemoveOnFinish,
        float life, float lifeVar,
        int positionType,
        float positionVarX, float positionVarY,
        float radialAccel, float radialAccelVar,
        float rotatePerSecond, float rotatePerSecondVar,
        float sourcePositionX, float sourcePositionY,
        float speed, float speedVar,
        byte startColorR, byte startColorG, byte startColorB, byte startColorA,
        byte startColorVarR, byte startColorVarG, byte startColorVarB, byte startColorVarA,
        float startRadius, float startRadiusVar,
        float startSize, float startSizeVar,
        float startSpin, float startSpinVar,
        float tangentialAccel, float tangentialAccelVar,
        string plistPath,string texturePath, string textureImageData,
        uint totalParticles
        );


        private readonly DllImporter mDll = new DllImporter();
        private ParticleSystem mParticleSystem = new ParticleSytstemFire();
        private string mFilePath = String.Empty;
        private bool mIsBackgroundMove; //keep not changes

        public ParticleEditorForm()
        {
            InitializeComponent();
            mIsBackgroundMove = true;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            string a = Environment.CurrentDirectory + "libcocos2d.dll";
            a = "libcocos2d.dll";
            mDll.Open(a);
            mDll.Invoke<MInitializeApplication, bool>(mEditorPanel.Handle.ToInt32());

            UpdateUI();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            mDll.Invoke<MGameLoop, bool>(16);
        }

        private void ParticleEditorFormFormClosing(object sender, FormClosingEventArgs e)
        {
            mDll.Invoke<MGameCleanUp, bool>();
            mDll.Close();
        }

        private void ParticleEditorFormFormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void PropertyGridPropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            mIsBackgroundMove = mParticleSystem.IsBackgroundMove;
            mPlayToolStripButton.Enabled = !mParticleSystem.IsLoop;

            mDll.Invoke<MParticleChanged, bool>(mParticleSystem.Scale,mParticleSystem.IsBackgroundMove, mParticleSystem.Angle, mParticleSystem.AngleVar, (int)mParticleSystem.DestBlendFunc, (int)mParticleSystem.SrcBlendFunc,
                mParticleSystem.Duration, mParticleSystem.EmissionRate, (int)mParticleSystem.Mode,
                mParticleSystem.EndColor.R, mParticleSystem.EndColor.G, mParticleSystem.EndColor.B, mParticleSystem.EndColor.A,
                mParticleSystem.EndColorVar.R, mParticleSystem.EndColorVar.G, mParticleSystem.EndColorVar.B, mParticleSystem.EndColorVar.A,
                mParticleSystem.EndRadius, mParticleSystem.EndRadiusVar,
                mParticleSystem.EndSize, mParticleSystem.EndSizeVar,
                mParticleSystem.EndSpin, mParticleSystem.EndSpinVar,
                mParticleSystem.GravityX, mParticleSystem.GravityY,
                mParticleSystem.IsAutoRemoveOnFinish, 
                mParticleSystem.Life, mParticleSystem.LifeVar,
                (int)mParticleSystem.PositionType,
                mParticleSystem.PosVarX, mParticleSystem.PosVarY,
                mParticleSystem.RadialAccel, mParticleSystem.RadialAccelVar,
                mParticleSystem.RotatePerSecond, mParticleSystem.RotatePerSecondVar,
                mParticleSystem.SourcePositionX, mParticleSystem.SourcePositionY,
                mParticleSystem.Speed, mParticleSystem.SpeedVar,
                mParticleSystem.StartColor.R, mParticleSystem.StartColor.G, mParticleSystem.StartColor.B, mParticleSystem.StartColor.A,
                mParticleSystem.StartColorVar.R, mParticleSystem.StartColorVar.G, mParticleSystem.StartColorVar.B, mParticleSystem.StartColorVar.A,
                mParticleSystem.StartRadius, mParticleSystem.StartRadiusVar,
                mParticleSystem.StartSize, mParticleSystem.StartSizeVar,
                mParticleSystem.StartSpin, mParticleSystem.StartSpinVar,
                mParticleSystem.TangentialAccel, mParticleSystem.TangentialAccelVar,
                mParticleSystem.PlistPath,mParticleSystem.TexturePath,mParticleSystem.TextureImageData,
                mParticleSystem.TotalParticles
                );


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mFilePath==String.Empty)
            {
                mFilePath = "default.plist";
            }

            
            mParticleSystem.SaveTo(mFilePath);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "plist files (*.plist)|*.plist";

            //dialog.DefaultExt = ".plist";
            //dialog.AddExtension = true;
            //dialog.CheckPathExists = true;
            
            //dialog.Filter = "plist files (*.plist)|*.plist";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mFilePath = dialog.FileName;
                mParticleSystem.SaveTo(mFilePath);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog=new OpenFileDialog();
            dialog.Filter = "plist files (*.plist)|*.plist";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                mFilePath = dialog.FileName;
                mParticleSystem=new ParticleSystem();
                mParticleSystem.Load(mFilePath);
                UpdateUI();
            }
        }

        private void fireworksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemFireworks();
            UpdateUI();
        }

        private void sunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemSun();
            UpdateUI();
        }

        private void smokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemSmoke();
            UpdateUI();
        }

        private void spiralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemSpiral();
            UpdateUI();
        }

        private void flowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemFlower();
            UpdateUI();
        }

        private void bigFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemBigFlower();
            UpdateUI();
        }

        private void rotFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemRotFlower();
            UpdateUI();
        }

        private void explosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemExplosion();
            UpdateUI();
        }

        private void galaxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemGalaxy();
            UpdateUI();
        }

        private void meteorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemMeteor();
            UpdateUI();
        }

        private void modernArtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemModernArt();
            UpdateUI();
        }

        private void radiusMode1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemRadiusMode1();
            UpdateUI();
        }

        private void radiusMode2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemRadiusMode2();
            UpdateUI();
        }

        private void snowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemSnow();
            UpdateUI();
        }

        private void rainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemRain();
            UpdateUI();
        }

        private void ringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemRing();
            UpdateUI();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mParticleSystem = new ParticleSytstemFire();
            UpdateUI();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form=new AboutForm();
            form.ShowDialog();
        }

        private void UpdateUI()
        {
            mParticleSystem.IsBackgroundMove = mIsBackgroundMove;
            mPlayToolStripButton.Enabled = !mParticleSystem.IsLoop;
            mPropertyGrid.SelectedObject = mParticleSystem;
            PropertyGridPropertyValueChanged(null, null);

        }

        private void mPlayToolStripButton_Click(object sender, EventArgs e)
        {
            PropertyGridPropertyValueChanged(null, null);
        }
    }
}
