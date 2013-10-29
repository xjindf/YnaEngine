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

        // Path
        public string SaveConfigPath { get; set; }
        public string SaveGamePath { get; set; }
        public string ContentPath { get; set; }

        public GameSettings()
        {
            // Screen
            Width = 1024;
            Height = 600;
            ReferenceWidth = 1024;
            ReferenceHeight = 600;
            IsFullscreen = false;

            // Audio
            SoundEnabled = true;
            SoundVolume = 1.0f;
            MusicEnabled = true;
            MusicVolume = 1.0f;

            // Input
            TouchEnabled = true;
            JoypadEnabled = true;
            KeyboardEnabled = true;
            MouseEnabled = true;

            // Storage
            SaveConfigPath = "data/config";
            SaveGamePath = "data/saves";
            ContentPath = "Content";
        }

        public void Load()
        {
            GameSettings settings = YnG.StorageManager.Load<GameSettings>(SaveConfigPath, "settings.yna");
        }

        public void Save()
        {
            YnG.StorageManager.Save<GameSettings>(SaveConfigPath, "settings.yna", this);
        }

        public void Clear()
        {
            
        }
    }
}
