using Microsoft.Xna.Framework;
using System;

namespace Yna.Engine.Scene
{
    [Serializable]
    public class SceneSettings
    {
        public bool FogEnabled { get; set; }
        public float FogStart { get; set; }
        public float FogEnd { get; set; }
        public Color FogColor { get; set; }
        public string BackgroundTexture { get; set; }
        public string[] Skybox { get; set; }
        public string Name { get; set; }

        public SceneSettings()
        {
            FogEnabled = false;
            FogStart = 10;
            FogEnd = 600;
            FogColor = Color.White;
            BackgroundTexture = String.Empty;
            Skybox = new string[] { String.Empty };
            Name = "Scene_" + YnRandom.GetInteger();
        }
    }
}
