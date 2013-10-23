// YnaEngine - Copyright (C) YnaEngine team
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Yna.Engine.Audio;
using Yna.Engine.Input;
using Yna.Engine.Storage;

namespace Yna.Engine
{
    /// <summary>
    /// Static class that expose important object relative to the current context like
    /// Game, GraphicsDevice, Input, etc...
    /// </summary>
    public static class YnG
    {
        private static int _width;
        private static int _height;
        private static Game _game;
        private static GraphicsDevice _device;
        private static GraphicsDeviceManager _graphics;
        private static ContentManager _content;

        /// <summary>
        /// Gets or Set the Game instance
        /// </summary>
        public static Game Game
        {
            get { return _game; }
            internal set { _game = value; }
        }

        /// <summary>
        /// Gets the GraphicsDevice instance relative to the Game object
        /// </summary>
        public static GraphicsDevice GraphicsDevice
        {
            get { return _device; }
            internal set { _device = value; }
        }

        #region Managers

        /// <summary>
        /// Gets the GraphicsDeviceManager relative to the Game object
        /// </summary>
        public static GraphicsDeviceManager GraphicsDeviceManager
        {
            get { return _graphics; }
            internal set { _graphics = value; }
        }

        /// <summary>
        /// Gets the ContentManager instance relative to the Game object
        /// </summary>
        public static ContentManager Content
        {
            get { return _content; }
            internal set { _content = value; }
        }

        /// <summary>
        /// Gets or Set the State Manager
        /// </summary>
        public static StateManager StateManager
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets or Set the audio manager
        /// </summary>
        public static AudioManager AudioManager { get; set; }

        /// <summary>
        /// Gets or sets the storage manager
        /// </summary>
        public static StorageManager StorageManager { get; set; }

        #endregion

        #region Inputs

        public static bool ShowMouse
        {
            get { return Game.IsMouseVisible; }
            set { Game.IsMouseVisible = value; }
        }

        #endregion

        #region StateManager

        // @deprecated
        public static void SetStateActive(string name, bool desactiveOtherStates)
        {
            LogError("YnG.SetStateActive", "YnG.LoadLevel");
            if (StateManager != null)
                StateManager.SetActive(name, desactiveOtherStates);
        }

        public static void LoadLevel(string name)
        {
            if (StateManager != null)
                StateManager.SetActive(name, true);
        }

        #endregion

        #region Deprecated

        public static int Width
        {
            get
            {
                LogError("YnG.Width", "YnScreen.Width");
                return YnScreen.Width;
            }
        }

        public static int Height
        {
            get
            {
                LogError("YnG.Height", "YnScreen.Height");
                return YnScreen.Height;
            }
        }

        /// <summary>
        /// Gets or Set the keyboard states
        /// </summary>
        public static YnKeyboard Keys 
        { 
            get 
            {
                LogError("YnG.Keys", "YnInput.Keys");
                return YnInput.Keys; 
            } 
        }

        /// <summary>
        /// Gets or Set the mouse states
        /// </summary>
        public static YnMouse Mouse 
        {
            get
            {
                LogError("YnG.Mouse", "YnInput.Mouse");
                return YnInput.Mouse;
            } 
        }

        /// <summary>
        /// Gets or Set the Gamepad states
        /// </summary>
        public static YnGamepad Gamepad 
        {
            get
            {
                LogError("YnG.Gamepad", "YnInput.Gamepad");
                return YnInput.Gamepad;
            } 
        }

        /// <summary>
        /// Gets or Set the Touch states
        /// </summary>
        public static YnTouch Touch 
        {
            get
            {
                LogError("YnG.Touch", "YnInput.Touch");
                return YnInput.Touch;
            }  
        }

        #endregion

        /// <summary>
        /// Close the game
        /// </summary>
        public static void Exit()
        {
            Game.Exit();
        }

        public static void LogError(string method, string replace)
        {
            string output = "[" + method + "] is deprecated use " + replace + " instead";
#if !WINDOWS_STOREAPP && !WINDOWS_PHONE && !ANDROID
            System.Console.Error.WriteLine(output);
#endif
        }
    }
}
