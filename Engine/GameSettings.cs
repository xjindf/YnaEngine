using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine
{
    [Serializable]
    public class GameSettings : ISettings
    {
        // Screen
        public int Width { get; set; }
        public int Height { get; set; }
        public int ReferenceWidth { get; set; }
        public int ReferenceHeight { get; set; }
        public bool IsFullscreen { get; set; }
        
        // Audio
        public float SoundVolume { get; set; }
        public float MusicVolume { get; set; }
        public bool SoundEnabled { get; set; }
        public bool MusicEnabled { get; set; }
        
        // Input
        public bool TouchEnabled { get; set; }
        public bool JoypadEnabled { get; set; }
        public bool KeyboardEnabled { get; set; }
        public bool MouseEnabled { get; set; }

        public GameSettings()
        {
            Width = 1024;
            Height = 600;
            ReferenceWidth = 1024;
            ReferenceHeight = 600;
            IsFullscreen = false;

            SoundEnabled = true;
            SoundVolume = 1.0f;
            MusicEnabled = true;
            MusicVolume = 1.0f;

            TouchEnabled = true;
            JoypadEnabled = true;
            KeyboardEnabled = true;
            MouseEnabled = true;
        }

        public void Load()
        {

        }

        public void Save()
        {

        }

        public void Clear()
        {

        }
    }
}
