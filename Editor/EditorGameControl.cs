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
        public GameObject GameObject { get; set; }

        public GameObjectClickedEventArgs(GameObject go)
        {
            GameObject = go;
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

        private void GameObjectClick_Handler(GameObject gameObject)
        {
            if (GameObjectClicked != null)
                GameObjectClicked(this, new GameObjectClickedEventArgs(gameObject));
        }

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

        public GameObject[] checkMouseClick(int x, int y, bool clicked = true)
        {
            List<GameObject> gameObjects = new List<GameObject>();
 
            foreach (YnEntity go in _gameObjects)
            {
                if (go.Rectangle.Contains(x, y))
                {
                    gameObjects.Add(go);

                    if (clicked)
                        GameObjectClick_Handler(go);
                }
            }

            foreach (YnEntity3D go3 in _gameObjects3D)
            {
                if (YnG3.MouseCollideWithObject(camera, go3) > 0 && GameObjectClicked != null)
                {
                    gameObjects.Add(go3);

                    if (clicked)
                        GameObjectClick_Handler(go3);
                }
            }

            if (gameObjects.Count == 0)
                GameObjectClick_Handler(null);

            return gameObjects.ToArray<GameObject>();
        }

        public void MoveGameObject(GameObject gameObject, int x, int y)
        {
            if (gameObject is YnEntity)
            {
                YnEntity go = gameObject as YnEntity;

                int index = _gameObjects.IndexOf(go);
                
                if (index >= 0)
                {
                    _gameObjects[index].X = x;
                    _gameObjects[index].Y = y;
                }
            }
            else if (gameObject is YnEntity3D)
            {
                YnEntity3D go = gameObject as YnEntity3D;
                int index = _gameObjects3D.IndexOf(go);

                if (index >= 0)
                {
                    Vector2 mousePos = new Vector2(x, y);
                    Vector3 mouseCoords = YnG3.GetScreenToWorldPosition(camera, ref mousePos);
                    _gameObjects3D[index].X = mouseCoords.X;
                    _gameObjects3D[index].Y = mouseCoords.Y;
                    _gameObjects3D[index].Z = mouseCoords.Z;
                }
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
