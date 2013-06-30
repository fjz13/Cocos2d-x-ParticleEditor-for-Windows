using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ParticleEditor
{

    public enum PositionType
    {
        /** Living particles are attached to the world and are unaffected by emitter repositioning. */
        Free,

        /** Living particles are attached to the world but will follow the emitter repositioning.
        Use case: Attach an emitter to an sprite, and you want that the emitter follows the sprite.
        */
        Relative,

        /** Living particles are attached to the emitter and are translated along with it. */
        Grouped,
    };

    public enum EmiiterMode
    {
        /** Gravity mode (A mode) */
        Gravity,

        /** Radius mode (B mode) */
        Radius,
    };



    public enum BlendFunc
    {
        GL_ZERO = 0,
        GL_ONE = 1,
        GL_SRC_COLOR = 0x0300,
        GL_ONE_MINUS_SRC_COLOR = 0x0301,
        GL_SRC_ALPHA = 0x0302,
        GL_ONE_MINUS_SRC_ALPHA = 0x0303,
        GL_DST_ALPHA = 0x0304,
        GL_ONE_MINUS_DST_ALPHA = 0x0305,

        GL_DST_COLOR = 0x0306,
        GL_ONE_MINUS_DST_COLOR = 0x0307,
        GL_SRC_ALPHA_SATURATE = 0x0308,
    }

    [DefaultPropertyAttribute("ParticleSystem")]
    public class ParticleSystem
    {
        public ParticleSystem()
        {
            TexturePath = String.Empty;
            IsBackgroundMove = true;
            Scale = 1.0f;

            DestBlendFunc = BlendFunc.GL_ONE_MINUS_SRC_ALPHA;
            SrcBlendFunc = BlendFunc.GL_SRC_ALPHA;
            Duration = -1;
            IsSaveTextureImageData = false;
            TextureImageData = string.Empty;
            PlistPath = string.Empty;
        }

        public bool IsLoop { get { return Math.Abs(Duration - -1) < 0.001; } }

        



        [CategoryAttribute("重力模式"), DescriptionAttribute("重力X，只在重力模式下起作用")]
        public float GravityX { get; set; }

        [CategoryAttribute("重力模式"), DescriptionAttribute("重力Y，只在重力模式下起作用")]
        public float GravityY { get; set; }

        [CategoryAttribute("重力模式"), DescriptionAttribute("速度，只在重力模式下起作用")]
        public float Speed { get; set; }

        [CategoryAttribute("重力模式"), DescriptionAttribute("速度变化范围，只在重力模式下起作用")]
        public float SpeedVar { get; set; }

        [CategoryAttribute("重力模式"), DescriptionAttribute("粒子切向加速度，只在重力模式下起作用")]
        public float TangentialAccel { get; set; }

        [CategoryAttribute("重力模式"), DescriptionAttribute("粒子切向加速度变化范围，只在重力模式下起作用")]
        public float TangentialAccelVar { get; set; }

        [CategoryAttribute("重力模式"), DescriptionAttribute("粒子径向加速度，只在重力模式下起作用")]
        public float RadialAccel { get; set; }

        [CategoryAttribute("重力模式"), DescriptionAttribute("粒子径向加速度变化范围，只在重力模式下起作用")]
        public float RadialAccelVar { get; set; }


        [CategoryAttribute("半径模式"), DescriptionAttribute("初始半径，只在半径模式下起作用")]
        public float StartRadius { get; set; }

        [CategoryAttribute("半径模式"), DescriptionAttribute("初始半径变化范围，只在半径模式下起作用")]
        public float StartRadiusVar { get; set; }


        [CategoryAttribute("半径模式"), DescriptionAttribute("结束半径，只在半径模式下起作用")]
        public float EndRadius { get; set; }

        [CategoryAttribute("半径模式"), DescriptionAttribute("结束半径变化范围，只在半径模式下起作用")]
        public float EndRadiusVar { get; set; }


        [CategoryAttribute("半径模式"), DescriptionAttribute("粒子围绕初始点的每秒旋转角度，只在半径模式下起作用")]
        public float RotatePerSecond { get; set; }

        [CategoryAttribute("半径模式"), DescriptionAttribute("粒子围绕初始点的每秒旋转角度的变化范围，只在半径模式下起作用")]
        public float RotatePerSecondVar { get; set; }

        [CategoryAttribute("主要"), DescriptionAttribute("运行时间，单位秒，-1：永远，结束后可点击工具栏播放再次发射")]
        public float Duration { get; set; }

        [CategoryAttribute("位置"), DescriptionAttribute("发射器位置X")]
        public float SourcePositionX { get; set; }

        [CategoryAttribute("位置"), DescriptionAttribute("发射器位置Y")]
        public float SourcePositionY { get; set; }

        [CategoryAttribute("位置"), DescriptionAttribute("发射器位置变化范围X")]
        public float PosVarX { get; set; }

        [CategoryAttribute("位置"), DescriptionAttribute("发射器位置变化范围Y")]
        public float PosVarY { get; set; }

        [CategoryAttribute("生命"), DescriptionAttribute("粒子生命")]
        public float Life { get; set; }

        [CategoryAttribute("生命"), DescriptionAttribute("粒子生命变化范围")]
        public float LifeVar { get; set; }

        [CategoryAttribute("角度"), DescriptionAttribute("粒子角度")]
        public float Angle { get; set; }

        [CategoryAttribute("角度"), DescriptionAttribute("粒子角度变化范围")]
        public float AngleVar { get; set; }

        [CategoryAttribute("大小"), DescriptionAttribute("粒子初始大小")]
        public float StartSize { get; set; }

        [CategoryAttribute("大小"), DescriptionAttribute("粒子初始大小变化范围")]
        public float StartSizeVar { get; set; }

        [CategoryAttribute("大小"), DescriptionAttribute("粒子结束大小,-1:和初始大小一致")]
        public float EndSize { get; set; }

        [CategoryAttribute("大小"), DescriptionAttribute("粒子结束大小变化范围")]
        public float EndSizeVar { get; set; }

        [CategoryAttribute("颜色"), DescriptionAttribute("粒子初始颜色")]
        public Color StartColor { get; set; }

        [CategoryAttribute("颜色"), DescriptionAttribute("粒子初始颜色变化范围")]
        public Color StartColorVar { get; set; }

        [CategoryAttribute("颜色"), DescriptionAttribute("粒子结束颜色")]
        public Color EndColor { get; set; }

        [CategoryAttribute("颜色"), DescriptionAttribute("粒子结束颜色变化范围")]
        public Color EndColorVar { get; set; }

        [CategoryAttribute("自旋"), DescriptionAttribute("粒子初始自旋角度")]
        public float StartSpin { get; set; }

        [CategoryAttribute("自旋"), DescriptionAttribute("粒子初始自旋角度变化范围")]
        public float StartSpinVar { get; set; }

        [CategoryAttribute("自旋"), DescriptionAttribute("粒子结束自旋角度")]
        public float EndSpin { get; set; }

        [CategoryAttribute("自旋"), DescriptionAttribute("粒子结束自旋角度变化范围")]
        public float EndSpinVar { get; set; }

        [CategoryAttribute("主要"), DescriptionAttribute("每秒喷发的粒子数目")]
        public float EmissionRate { get; set; }

        [CategoryAttribute("主要"), DescriptionAttribute("最大粒子数目")]
        public uint TotalParticles { get; set; }

        [CategoryAttribute("纹理渲染"), DescriptionAttribute("纹理路径，目前只可为Debug.win32目录下文件名")]
        public string TexturePath { get; set; }

        [CategoryAttribute("纹理渲染"), DescriptionAttribute("纹理数据")]
        public string TextureImageData { get; set; }

        [CategoryAttribute("纹理渲染"), DescriptionAttribute("源纹理混合")]
        public BlendFunc SrcBlendFunc { get; set; }

        [CategoryAttribute("纹理渲染"), DescriptionAttribute("目的纹理混合")]
        public BlendFunc DestBlendFunc { get; set; }

        [CategoryAttribute("位置"), DescriptionAttribute("粒子位置类型")]
        public PositionType PositionType { get; set; }

        [CategoryAttribute("主要"), DescriptionAttribute("粒子结束时是否自动删除")]
        public bool IsAutoRemoveOnFinish { get; set; }

        [CategoryAttribute("主要"), DescriptionAttribute("喷发器模式")]
        public EmiiterMode Mode { get; set; }

        [CategoryAttribute("编辑器"), DescriptionAttribute("背景图片是否移动")]
        public bool IsBackgroundMove { get; set; }

        [CategoryAttribute("编辑器"), DescriptionAttribute("画布缩放大小")]
        public float Scale { get; set; }

        [CategoryAttribute("编辑器"), DescriptionAttribute("是否把图片数据编码到文件里导出")]
        public bool IsSaveTextureImageData { get; set; }

        [CategoryAttribute("编辑器"), DescriptionAttribute("plist路径")]
        public string PlistPath { get; set; }

        protected Color ToColor(float r, float g, float b, float a)
        {
            return Color.FromArgb((int)(a * 255), (int)(r * 255), (int)(g * 255), (int)(b * 255));
        }

        public void SaveTo(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {

                using (XmlTextWriter writer = new XmlTextWriter(fileStream, Encoding.UTF8))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.WriteStartDocument();

                    writer.WriteDocType("plist", "-//Apple//DTD PLIST 1.0//EN", "http://www.apple.com/DTDs/PropertyList-1.0.dtd", null);
                    writer.WriteStartElement("plist");
                    writer.WriteAttributeString("version", "1.0");
                    writer.WriteStartElement("dict");

                    WriteFloat(writer, "angle", Angle);
                    WriteFloat(writer, "angleVariance", AngleVar);


                    WriteInt(writer, "blendFuncDestination", (int)DestBlendFunc);
                    WriteInt(writer, "blendFuncSource", (int)SrcBlendFunc);

                    WriteFloat(writer, "duration", Duration);
                    WriteFloat(writer, "emitterType", (float)Mode);
                    WriteFloat(writer, "emissionRate", EmissionRate);


                    WriteFloat(writer, "finishColorAlpha", EndColor.A / 255.0f);
                    WriteFloat(writer, "finishColorBlue", EndColor.B / 255.0f);
                    WriteFloat(writer, "finishColorGreen", EndColor.G / 255.0f);
                    WriteFloat(writer, "finishColorRed", EndColor.R / 255.0f);

                    WriteFloat(writer, "finishColorVarianceAlpha", EndColorVar.A / 255.0f);
                    WriteFloat(writer, "finishColorVarianceBlue", EndColorVar.B / 255.0f);
                    WriteFloat(writer, "finishColorVarianceGreen", EndColorVar.G / 255.0f);
                    WriteFloat(writer, "finishColorVarianceRed", EndColorVar.R / 255.0f);

                    WriteFloat(writer, "rotationStart", StartSpin);
                    WriteFloat(writer, "rotationStartVariance", StartSpinVar);
                    WriteFloat(writer, "rotationEnd", EndSpin);
                    WriteFloat(writer, "rotationEndVariance", EndSpinVar);

                    WriteFloat(writer, "finishParticleSize", EndSize);
                    WriteFloat(writer, "finishParticleSizeVariance", EndSizeVar);

                    WriteFloat(writer, "gravityx", GravityX);
                    WriteFloat(writer, "gravityy", GravityY);
                    WriteFloat(writer, "maxParticles", TotalParticles);


                    WriteFloat(writer, "maxRadius", StartRadius);
                    WriteFloat(writer, "maxRadiusVariance", StartRadiusVar);
                    WriteFloat(writer, "minRadius", EndRadius);
                    WriteFloat(writer, "minRadiusVariance", EndRadiusVar);



                    WriteFloat(writer, "particleLifespan", Life);
                    WriteFloat(writer, "particleLifespanVariance", LifeVar);

                    WriteFloat(writer, "radialAccelVariance", RadialAccelVar);
                    WriteFloat(writer, "radialAcceleration", RadialAccel);

                    WriteFloat(writer, "rotatePerSecond", RotatePerSecond);
                    WriteFloat(writer, "rotatePerSecondVariance", RotatePerSecondVar);

                    WriteFloat(writer, "sourcePositionVariancex", PosVarX);
                    WriteFloat(writer, "sourcePositionVariancey", PosVarY);

                    WriteFloat(writer, "sourcePositionx", SourcePositionX);
                    WriteFloat(writer, "sourcePositiony", SourcePositionY);


                    WriteFloat(writer, "speed", Speed);
                    WriteFloat(writer, "speedVariance", SpeedVar);


                    WriteFloat(writer, "startColorAlpha", StartColor.A / 255.0f);
                    WriteFloat(writer, "startColorBlue", StartColor.B / 255.0f);
                    WriteFloat(writer, "startColorGreen", StartColor.G / 255.0f);
                    WriteFloat(writer, "startColorRed", StartColor.R / 255.0f);

                    WriteFloat(writer, "startColorVarianceAlpha", StartColorVar.A / 255.0f);
                    WriteFloat(writer, "startColorVarianceBlue", StartColorVar.B / 255.0f);
                    WriteFloat(writer, "startColorVarianceGreen", StartColorVar.G / 255.0f);
                    WriteFloat(writer, "startColorVarianceRed", StartColorVar.R / 255.0f);


                    WriteFloat(writer, "startParticleSize", StartSize);
                    WriteFloat(writer, "startParticleSizeVariance", StartSizeVar);

                    WriteFloat(writer, "tangentialAccelVariance", TangentialAccelVar);
                    WriteFloat(writer, "tangentialAcceleration", TangentialAccel);

                    WriteString(writer, "textureFileName", TexturePath);

                    if (IsSaveTextureImageData)
                    {
                        if (string.IsNullOrEmpty(TextureImageData))
                        {
                            if (File.Exists(TexturePath))
                            {
                                var data=File.ReadAllBytes(TexturePath);
                                MemoryStream ms=new MemoryStream();
                                DeflaterOutputStream outputStream = new DeflaterOutputStream(ms);
                                outputStream.Write(data,0,data.Length);
                                outputStream.Close();
                                data = ms.ToArray();

                                TextureImageData = Convert.ToBase64String(data);
                            }
                        }

                        if (TextureImageData.Length > 0)
                        {
                            WriteString(writer, "textureImageData", TextureImageData);
                        }
                    }

                    writer.WriteEndElement();
                }
                
                fileStream.Close();
            }

        }


        public void Load(string filePath)
        {
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                

                using (var reader = new StreamReader(fileStream))
                {

                    var dict = ReadAll(reader);

                    byte a, r, g, b;


                    Angle = ReadFloat(dict, "angle");
                    AngleVar = ReadFloat(dict, "angleVariance");


                    DestBlendFunc = (BlendFunc)ReadInt(dict, "blendFuncDestination");
                    SrcBlendFunc = (BlendFunc)ReadInt(dict, "blendFuncSource");

                    Duration = ReadFloat(dict, "duration");
                    Mode = (EmiiterMode)(int)ReadFloat(dict, "emitterType");


                    a = (byte)(int)(ReadFloat(dict, "finishColorAlpha") * 255.0f);
                    b = (byte)(int)(ReadFloat(dict, "finishColorBlue") * 255.0f);
                    g = (byte)(int)(ReadFloat(dict, "finishColorGreen") * 255.0f);
                    r = (byte)(int)(ReadFloat(dict, "finishColorRed") * 255.0f);
                    EndColor = Color.FromArgb(a, r, g, b);


                    a = (byte)(int)(ReadFloat(dict, "finishColorVarianceAlpha") * 255.0f);
                    b = (byte)(int)(ReadFloat(dict, "finishColorVarianceBlue") * 255.0f);
                    g = (byte)(int)(ReadFloat(dict, "finishColorVarianceGreen") * 255.0f);
                    r = (byte)(int)(ReadFloat(dict, "finishColorVarianceRed") * 255.0f);
                    EndColorVar = Color.FromArgb(a, r, g, b);

                    StartSpin = ReadFloat(dict, "rotationStart");
                    StartSpinVar = ReadFloat(dict, "rotationStartVariance");
                    EndSpin = ReadFloat(dict, "rotationEnd");
                    EndSpinVar = ReadFloat(dict, "rotationEndVariance");


                    EndSize = ReadFloat(dict, "finishParticleSize");
                    EndSizeVar = ReadFloat(dict, "finishParticleSizeVariance");

                    GravityX = ReadFloat(dict, "gravityx");
                    GravityY = ReadFloat(dict, "gravityy");

                    TotalParticles = (uint)ReadFloat(dict, "maxParticles");

                    StartRadius = ReadFloat(dict, "maxRadius");
                    StartRadiusVar = ReadFloat(dict, "maxRadiusVariance");
                    EndRadius = ReadFloat(dict, "minRadius");
                    EndRadiusVar = ReadFloat(dict, "minRadiusVariance");

                    Life = ReadFloat(dict, "particleLifespan");
                    LifeVar = ReadFloat(dict, "particleLifespanVariance");

                    RadialAccelVar = ReadFloat(dict, "radialAccelVariance");
                    RadialAccel = ReadFloat(dict, "radialAcceleration");
                    RotatePerSecond = ReadFloat(dict, "rotatePerSecond");
                    RotatePerSecondVar = ReadFloat(dict, "rotatePerSecondVariance");

                    PosVarX = ReadFloat(dict, "sourcePositionVariancex");
                    PosVarY = ReadFloat(dict, "sourcePositionVariancey");


                    SourcePositionX = ReadFloat(dict, "sourcePositionx");
                    SourcePositionY = ReadFloat(dict, "sourcePositiony");

                    Speed = ReadFloat(dict, "speed");
                    SpeedVar = ReadFloat(dict, "speedVariance");

                    a = (byte)(int)(ReadFloat(dict, "startColorAlpha") * 255.0f);
                    b = (byte)(int)(ReadFloat(dict, "startColorBlue") * 255.0f);
                    g = (byte)(int)(ReadFloat(dict, "startColorGreen") * 255.0f);
                    r = (byte)(int)(ReadFloat(dict, "startColorRed") * 255.0f);
                    StartColor = Color.FromArgb(a, r, g, b);


                    a = (byte)(int)(ReadFloat(dict, "startColorVarianceAlpha") * 255.0f);
                    b = (byte)(int)(ReadFloat(dict, "startColorVarianceBlue") * 255.0f);
                    g = (byte)(int)(ReadFloat(dict, "startColorVarianceGreen") * 255.0f);
                    r = (byte)(int)(ReadFloat(dict, "startColorVarianceRed") * 255.0f);
                    StartColorVar = Color.FromArgb(a, r, g, b);

                    StartSize = ReadFloat(dict, "startParticleSize");
                    StartSizeVar = ReadFloat(dict, "startParticleSizeVariance");
                    TangentialAccelVar = ReadFloat(dict, "tangentialAccelVariance");
                    TangentialAccel = ReadFloat(dict, "tangentialAcceleration");
                    TexturePath = ReadString(dict, "textureFileName");

                    EmissionRate = ReadFloat(dict, "emissionRate");

                    TextureImageData = ReadString(dict, "textureImageData");

                    if (EmissionRate == 0)
                    {
                        EmissionRate = TotalParticles / Life;
                    }
                }

                FileInfo info=new FileInfo(filePath);
                PlistPath = info.DirectoryName;
               

                fileStream.Close();
            }
        }

        private void WriteInt(XmlTextWriter writer, string name, int val)
        {
            writer.WriteElementString("key",name);
            writer.WriteElementString("integer", val.ToString(CultureInfo.InvariantCulture));
        }

        private void WriteFloat(XmlTextWriter writer, string name, float val)
        {
            writer.WriteElementString("key", name);
            writer.WriteElementString("real", val.ToString(CultureInfo.InvariantCulture));
        }

        private void WriteString(XmlTextWriter writer, string name, string val)
        {
            writer.WriteElementString("key", name);
            writer.WriteElementString("string", val);
        }


        private Dictionary<string, string> ReadAll(StreamReader reader)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            reader.ReadLine();
            reader.ReadLine();
            reader.ReadLine();
            reader.ReadLine();

            while (true)
            {
                string name = reader.ReadLine().Trim();
                if (name.Contains("</dict>"))
                {
                    break;
                }
                string value = reader.ReadLine().Trim();
                if (value.Contains("</dict>"))
                {
                    break;
                }

                name = name.Replace("<key>", String.Empty);
                name = name.Replace("</key>", String.Empty);

                value = value.Replace("<real>", String.Empty);
                value = value.Replace("</real>", String.Empty);

                value = value.Replace("<string>", String.Empty);
                value = value.Replace("</string>", String.Empty);

                value = value.Replace("<integer>", String.Empty);
                value = value.Replace("</integer>", String.Empty);

                result[name] = value;

            }


            return result;
        }

        private int ReadInt(Dictionary<string, string> dict, string name)
        {
            if (!dict.ContainsKey(name))
            {
                return 0;
            }
            return int.Parse(dict[name]);
        }

        private float ReadFloat(Dictionary<string, string> dict, string name)
        {
            if (!dict.ContainsKey(name))
            {
                return 0;
            }
            return float.Parse(dict[name], CultureInfo.InvariantCulture);
        }

        private string ReadString(Dictionary<string, string> dict, string name)
        {
            if (!dict.ContainsKey(name))
            {
                return string.Empty;
            }
            return dict[name];
        }
    }
}
