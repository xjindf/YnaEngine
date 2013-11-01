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
    using Yna.Engine.Scene;
    using YnScene = Yna.Engine.Scene.Scene;
    /// <summary>
    /// Static class that expose important object relative to the current context like
    /// Game, GraphicsDevice, Input, etc...
    /// </summary>
    public static class YnG
    {
        private static Game _game;
        private static GraphicsDevice _device;
        private static GraphicsDeviceManager _graphics;
        private static ContentManager _content;
        internal static YnScene _currentScene;

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

        public static YnScene CurrentScene
        {
            get { return _currentScene; }
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
        /// Gets the Scene Manager
        /// </summary>
        public static SceneManager SceneManager
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

        public static void LoadLevel(string name)
        {
            SceneManager.LoadScene(name);
        }

        public static void LoadLevel(int id)
        {
            SceneManager.LoadScene(id);
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
