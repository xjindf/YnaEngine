using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Yna.Engine.Graphics2D;
using Yna.Engine.Graphics3D;
using Yna.Engine.Graphics3D.Camera;

namespace Yna.Engine
{
    public class Scene
    {
        public string Name { get; set; }

        private bool _initialized;
        private bool _assetLoaded;
        private DirectionalLight[] _lights;

        protected List<YnEntity> _gameObjects;
        private int _nbGameObjects;
        protected List<YnEntity3D> _gameObjects3D;
        private int _nbGameObjects3D;
        protected BaseCamera mainCamera;
        protected GraphicsDevice graphicsDevice;
        protected SpriteBatch spriteBatch;
        protected SceneSettings sceneSettings;

        public Color ClearColor;

        public Scene()
        {
            if (YnTime.Service == null)
                throw new Exception("[Scene] The YnTime service is not active");

            ClearColor = Color.Black;

            _gameObjects = new List<YnEntity>();
            _gameObjects3D = new List<YnEntity3D>();

            _assetLoaded = false;
            _initialized = false;

            sceneSettings = new SceneSettings();
        }

        /// <summary>
        /// Add a light to the scene. Note that you can add up to three lights on the scene.
        /// </summary>
        /// <param name="light">The light to add</param>
        /// <returns>Return true if the first light has been replaced by this one, otherwise return false.</returns>
        public bool AddLight(DirectionalLight light)
        {
            if (_lights.Length > 3)
            {
                _lights[0] = light;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Add a 2D game object on the scene. It's initialized and loaded if it's not.
        /// </summary>
        /// <param name="gameObject">The game object to add.</param>
        public void AddGameObject(YnEntity gameObject)
        {
            if (!gameObject.Initialized)
                gameObject.Initialize();

            if (!gameObject.AssetLoaded)
                gameObject.LoadContent();

            _gameObjects.Add(gameObject);
            _nbGameObjects++;
        }

        /// <summary>
        /// Add a 3D game object on the scene. It's initialized and loaded if it's not.
        /// </summary>
        /// <param name="gameObject">The game object to add.</param>
        public void AddGameObject(YnEntity3D gameObject)
        {
            if (!gameObject.Initialized)
                gameObject.Initialize();

            if (!gameObject.AssetLoaded)
                gameObject.LoadContent();

            _gameObjects3D.Add(gameObject);
            _nbGameObjects3D++;
        }

        /// <summary>
        /// Initialize all game objects and scene components.
        /// </summary>
        public virtual void Initialize()
        {
            if (!_initialized)
            {
                foreach (YnEntity go in _gameObjects)
                    go.Initialize();

                foreach (YnEntity3D go3 in _gameObjects3D)
                    go3.Initialize();

                if (spriteBatch == null)
                    spriteBatch = new SpriteBatch(YnG.GraphicsDevice);

                if (mainCamera == null)
                    mainCamera = new FirstPersonCamera();
            }
        }

        /// <summary>
        /// Load assets for the scene.
        /// </summary>
        public virtual void LoadContent()
        {
            if (!_assetLoaded)
            {
                foreach (YnEntity go in _gameObjects)
                    go.LoadContent();

                foreach (YnEntity3D go3 in _gameObjects3D)
                    go3.LoadContent();
            }
        }

        /// <summary>
        /// Method called before the update method.
        /// </summary>
        public virtual void BeforeUpdate()
        {

        }

        /// <summary>
        /// Update logic of game objects 2D and 3D.
        /// </summary>
        public virtual void Update()
        {
            for (int i = 0; i < _nbGameObjects; i++)
            {
                if (_gameObjects[i].Enabled)
                    _gameObjects[i].Update(YnTime.Service.GameTime);
            }

            for (int i = 0; i < _nbGameObjects3D; i++)
            {
                if (_gameObjects3D[i].Enabled)
                    _gameObjects3D[i].Update(YnTime.Service.GameTime);
            }
        }

        /// <summary>
        /// Method called after update method.
        /// </summary>
        public virtual void AfterUpdate()
        {

        }

        /// <summary>
        /// Draw the scene on screen.
        /// </summary>
        public virtual void Draw()
        {
            graphicsDevice.Clear(ClearColor);

            // 2D
            if (_nbGameObjects > 0)
            {
                spriteBatch.Begin();

                for (int i = 0; i < _nbGameObjects; i++)
                {
                    if (_gameObjects[i].Visible && _gameObjects[i].Layer != SceneLayer.Layer2D)
                    _gameObjects[i].Draw(YnTime.Service.GameTime, spriteBatch);
                }

                spriteBatch.End();
            }

            // 3D
            if (_nbGameObjects > 0)
            {
                YnG3.RestoreGraphicsDeviceStates();

                for (int i = 0; i < _nbGameObjects3D; i++)
                {
                    if (_gameObjects3D[i].Visible && _gameObjects3D[i].Layer == SceneLayer.Layer3D)
                        _gameObjects3D[i].Draw(YnTime.Service.GameTime, graphicsDevice, mainCamera);
                }
            }

            // GUI
            if (_nbGameObjects > 0)
            {
                spriteBatch.Begin();

                for (int i = 0; i < _nbGameObjects; i++)
                {
                    if (_gameObjects[i].Visible && _gameObjects[i].Layer != SceneLayer.GUI)
                        _gameObjects[i].Draw(YnTime.Service.GameTime, spriteBatch);
                }

                spriteBatch.End();
            }
        }
    }
}
