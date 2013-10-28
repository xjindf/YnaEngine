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
        private bool _is3DScene;
        private bool _initialized;
        private bool _assetLoaded;
        private DirectionalLight[] _lights;

        protected GameTime gameTime;
        private Stopwatch _stopWatch;
        private TimeSpan _lastUpdate;

        protected List<YnEntity> _gameObjects;
        protected List<YnEntity3D> _gameObjects3D;
        protected BaseCamera camera;
        protected GraphicsDevice graphicsDevice;
        protected SpriteBatch spriteBatch;

        public Color ClearColor;

        public Scene()
        {
            ClearColor = Color.Black;

            camera = new FixedCamera();
            _gameObjects = new List<YnEntity>();
            _gameObjects3D = new List<YnEntity3D>();

            _is3DScene = true;
            _assetLoaded = false;
            _initialized = false;

            _lastUpdate = new TimeSpan(DateTime.Now.Ticks);
            _stopWatch = new Stopwatch();
            _stopWatch.Start();

            gameTime = new GameTime();
        }

        public bool AddLight(DirectionalLight light)
        {
            if (_lights.Length > 3)
            {
                _lights[0] = light;
                return true;
            }
            return false;
        }

        public void AddGameObject(YnEntity gameObject)
        {
            if (!gameObject.Initialized)
                gameObject.Initialize();

            if (!gameObject.AssetLoaded)
                gameObject.LoadContent();

            _gameObjects.Add(gameObject);
        }

        public void AddGameObject(YnEntity3D gameObject)
        {
            if (!gameObject.Initialized)
                gameObject.Initialize();

            if (!gameObject.AssetLoaded)
                gameObject.LoadContent();

            _gameObjects3D.Add(gameObject);
        }

        protected virtual void Initialize()
        {
            if (!_initialized)
            {
                foreach (YnEntity go in _gameObjects)
                    go.Initialize();

                foreach (YnEntity3D go3 in _gameObjects3D)
                    go3.Initialize();

                if (spriteBatch == null)
                    spriteBatch = new SpriteBatch(YnG.GraphicsDevice);

                if (camera == null)
                    camera = new FirstPersonCamera();
            }
        }

        protected virtual void LoadContent()
        {
            if (!_assetLoaded)
            {
                foreach (YnEntity go in _gameObjects)
                    go.LoadContent();

                foreach (YnEntity3D go3 in _gameObjects3D)
                    go3.LoadContent();
            }
        }

        protected void UpdateTime()
        {
            TimeSpan total = _stopWatch.Elapsed;
            TimeSpan elapsed = total - _lastUpdate;
            gameTime.ElapsedGameTime = elapsed;
            gameTime.TotalGameTime = total;
        }

        protected virtual void BeforeUpdate()
        {

        }

        protected virtual void Update()
        {
            foreach (YnEntity go in _gameObjects)
                go.Update(gameTime);

            foreach (YnEntity3D go3 in _gameObjects3D)
                go3.Update(gameTime);
        }

        protected virtual void AfterUpdate()
        {

        }

        protected virtual void Draw()
        {
            graphicsDevice.Clear(ClearColor);

            if (_is3DScene)
            {
                if (_gameObjects.Count > 0)
                {
                    spriteBatch.Begin();

                    foreach (YnEntity go in _gameObjects)
                        go.Draw(gameTime, spriteBatch);

                    spriteBatch.End();
                }

                YnG3.RestoreGraphicsDeviceStates();

                foreach (YnEntity3D go3 in _gameObjects3D)
                    go3.Draw(gameTime, graphicsDevice, camera);
            }

            if (_gameObjects.Count > 0)
            {
                spriteBatch.Begin();

                foreach (YnEntity go in _gameObjects)
                    go.Draw(gameTime, spriteBatch);

                spriteBatch.End();
            }
        }
    }
}
