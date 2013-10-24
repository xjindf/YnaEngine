using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yna.Engine;
using Yna.Engine.Graphics2D;
using Yna.Engine.Graphics2D.Scene;
using Yna.Engine.Winforms;
using System.Diagnostics;
using Yna.Engine.Graphics3D;
using Yna.Engine.Graphics3D.Camera;

namespace Yna.Editor
{
    public class GameObjectClickedEventArgs : EventArgs
    {
        public YnEntity GameObject { get; set; }
        public YnEntity3D GameObject3D { get; set; }

        public GameObjectClickedEventArgs(YnEntity go, YnEntity3D go3)
        {
            GameObject = go;
            GameObject3D = go3;
        }
    }

    public class EditorGameControl : YnGameControl
    {
        public enum GameObjectType
        {
            GameObject2D = 0, GameObject3D, NonDrawable
        }

        public Color ClearColor;

        private GameTime gameTime;
        private Stopwatch _stopWatch;
        private TimeSpan _lastUpdate;

        private bool _is3DScene;
        private BaseCamera camera;
        private List<YnEntity> _gameObjects;
        private List<YnEntity3D> _gameObjects3D;

        public event EventHandler<GameObjectClickedEventArgs> GameObjectClicked = null;

        public void AddGameObject(YnEntity gameObject)
        {
            gameObject.LoadContent();
            gameObject.Initialize();
            _gameObjects.Add(gameObject);
        }

        public void AddGameObject(YnEntity3D gameObject)
        {
            gameObject.LoadContent();
            gameObject.Initialize();
            _gameObjects3D.Add(gameObject);
        }

        public void checkMouseClick(int x, int y)
        {
            foreach (YnEntity go in _gameObjects)
            {
                if (go.Rectangle.Contains(x, y) && GameObjectClicked != null)
                    GameObjectClicked(this, new GameObjectClickedEventArgs(go, null));
            }

            foreach (YnEntity3D go3 in _gameObjects3D)
            {
                if (YnG3.MouseCollideWithObject(camera, go3) > 0 && GameObjectClicked != null)
                    GameObjectClicked(this, new GameObjectClickedEventArgs(null, go3));
            }
        }

        protected override void Initialize()
        {
            base.Initialize();
            ClearColor = Color.Black;

            camera = new FixedCamera();
            _gameObjects = new List<YnEntity>();
            _gameObjects3D = new List<YnEntity3D>();

            _lastUpdate = new TimeSpan(DateTime.Now.Ticks);
            _stopWatch = new Stopwatch();
            _stopWatch.Start();

            _is3DScene = true;

            gameTime = new GameTime();
        }

        protected override void Update()
        {
            UpdateTime();

            foreach (YnEntity go in _gameObjects)
                go.Update(gameTime);

            foreach (YnEntity3D go3 in _gameObjects3D)
                go3.Update(gameTime);
        }

        protected void UpdateTime()
        {
            TimeSpan total = _stopWatch.Elapsed;
            TimeSpan elapsed = total - _lastUpdate;
            gameTime.ElapsedGameTime = elapsed;
            gameTime.TotalGameTime = total;
        }

        protected override void Draw()
        {
            GraphicsDevice.Clear(ClearColor);

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
                    go3.Draw(gameTime, GraphicsDevice, camera);
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
