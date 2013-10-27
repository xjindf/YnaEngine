using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yna.Engine.Graphics2D;
using Yna.Engine.Graphics3D;
using Yna.Engine.Graphics3D.Camera;

namespace Yna.Engine
{
    class Scene
    {
        private bool _is3DScene;
        private BaseCamera camera;
        private List<YnEntity> _gameObjects;
        private List<YnEntity3D> _gameObjects3D;
        private GameTime gameTime;
        public Color ClearColor;
        GraphicsDevice device;
        SpriteBatch spriteBatch;
        DirectionalLight[] lights;

        protected virtual void LoadContent()
        {
            foreach (YnEntity go in _gameObjects)
                go.LoadContent();

            foreach (YnEntity3D go3 in _gameObjects3D)
                go3.LoadContent();
        }

        protected virtual void Update()
        {
            foreach (YnEntity go in _gameObjects)
                go.Update(gameTime);

            foreach (YnEntity3D go3 in _gameObjects3D)
                go3.Update(gameTime);
        }

        protected virtual void Draw()
        {
            device.Clear(ClearColor);

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
                    go3.Draw(gameTime, device, camera);
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
