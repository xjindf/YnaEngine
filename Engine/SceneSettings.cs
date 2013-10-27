using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine
{
    [Serializable]
    public struct SceneSettings
    {
        public bool FogEnabled { get; set; }
        public float FogStart { get; set; }
        public float FogEnd { get; set; }
        public Color FogColor { get; set; }
        public string BackgroundTexture { get; set; }
        public string[] Skybox { get; set; }
    }
}
