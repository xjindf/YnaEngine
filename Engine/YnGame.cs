// YnaEngine - Copyright (C) YnaEngine team
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Yna.Engine.Audio;
using Yna.Engine.Input;
using Yna.Engine.Storage;

namespace Yna.Engine
{
    /// <summary>
    /// The game class
    /// </summary>
    public class YnGame : Game
    {
        protected GraphicsDeviceManager graphics = null;
        public static string GameTitle = "Yna Game";
        public static string GameVersion = "1.0.0.0";

        #region Constructors

        /// <summary>
        /// Create and setup the game engine
        /// Graphics, Services and helpers are initialized
        /// </summary>
        public YnGame()
            : base()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content"; 

            // Registry globals objects
            YnG.Game = this;
            YnG.GraphicsDevice = GraphicsDevice;
            YnG.GraphicsDeviceManager = this.graphics;
            YnG.Content = this.Content;
            YnG.StateManager = new StateManager(this);
            YnG.StorageManager = new StorageManager();
            YnG.AudioManager = new AudioManager();

            YnInput.Keys = new YnKeyboard(this);
            YnInput.Mouse = new YnMouse(this);
            YnInput.Gamepad = new YnGamepad(this);
            YnInput.Touch = new YnTouch(this);

            Components.Add(YnInput.Keys);
            Components.Add(YnInput.Mouse);
            Components.Add(YnInput.Gamepad);
            Components.Add(YnInput.Touch);
            Components.Add(YnG.StateManager);

            YnScreen.Width = this.graphics.PreferredBackBufferWidth;
            YnScreen.Height = this.graphics.PreferredBackBufferHeight;
            YnScreen.ReferenceWidth = graphics.PreferredBackBufferWidth;
            YnScreen.ReferenceHeight = graphics.PreferredBackBufferHeight;
#if !ANDROID
            this.Window.Title = String.Format("{0} - v{1}", GameTitle, GameVersion);
            this.Window.ClientSizeChanged += Window_ClientSizeChanged;
#endif

#if WINDOWS_PHONE_7
            // 30 FPS for Windows Phone 7
            TargetElapsedTime = TimeSpan.FromTicks(333333);

            // Battery saving when screen suspended
            InactiveSleepTime = TimeSpan.FromSeconds(1);
#endif
        }

        public YnGame(int width, int height, string title)
            : this()
        {
#if XNA || MONOGAME && (OPENGL || DIRECTX || LINUX || MACOSX) ||SDL2
            YnScreen.Setup(width, height, width, height, true);
            this.Window.Title = title;
#endif
        }

        #endregion

        protected void Window_ClientSizeChanged(object sender, EventArgs e)
        {
            YnScreen.Width = this.graphics.PreferredBackBufferWidth;
            YnScreen.Height = this.graphics.PreferredBackBufferHeight;
            // TODO use YnScreen
        }

        #region GameState pattern

        protected override void Initialize()
        {
            base.Initialize();

            if (YnG.GraphicsDevice == null)
                YnG.GraphicsDevice = GraphicsDevice;
        }

        /// <summary>
        /// Load assets from content manager
        /// </summary>
        protected override void LoadContent()
        {
            base.LoadContent();
            GraphicsDevice.Viewport = new Viewport(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);
        }

        /// <summary>
        /// Unload assets off content manager and suspend managers
        /// </summary>
        protected override void UnloadContent()
        {
            base.UnloadContent();
            YnG.AudioManager.Dispose();
        }
        #endregion
    }
}

