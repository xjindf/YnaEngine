using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine
{
    [Serializable]
    public struct GameSettings
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int ReferenceWidth { get; set; }
        public int ReferenceHeight { get; set; }
        public bool IsFullscreen { get; set; }
    }
}
