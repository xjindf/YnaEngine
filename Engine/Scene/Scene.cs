using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Yna.Engine.Graphics2D;
using Yna.Engine.Graphics3D;
using Yna.Engine.Graphics3D.Camera;

namespace Yna.Engine.Scene
{
    public class Scene
    {
        public string Name { get; set; }

        private bool _initialized;
        private bool _assetLoaded;
        private DirectionalLight[] _lights;

        protected List<GameObject> gameObjects;
        protected List<Component> _components;
        protected Dictionary<int, List<DrawableComponent>> _drawableComponents;

        protected GraphicsDevice graphicsDevice;
        protected SpriteBatch spriteBatch;
        protected SceneSettings sceneSettings;

        public Color ClearColor;

        public Scene()
        {
            if (YnTime.Service == null)
                throw new Exception("[Scene] The Time service is not active");

            ClearColor = Color.Black;

            _components = new List<Component>();
            _drawableComponents = new Dictionary<int, List<DrawableComponent>>();

            string[] layers = Enum.GetNames(typeof(SceneLayer));
            for (int i = 0; i < layers.Length; i++)
                _drawableComponents.Add(i, new List<DrawableComponent>());

            _assetLoaded = false;
            _initialized = false;

            sceneSettings = new SceneSettings();
        }

        /// <summary>
        /// Add a 2D game object on the scene. It's initialized and loaded if it's not.
        /// </summary>
        /// <param name="gameObject">The game object to add.</param>
        public void AddGameObject(YnEntity gameObject)
        {
            if (gameObjects.IndexOf(gameObject) >= 0)
            {
                if (_initialized && !gameObject.Initialized)
                    gameObject.Initialize();

                gameObjects.Add(gameObject);
            }
        }

        protected void UpdateComponents(Component component)
        {
            _components.Add(component);

            if (component is DrawableComponent)
            {
                DrawableComponent drawable = component as DrawableComponent;
                _drawableComponents[(int)drawable.GameObject.Layer].Add(drawable);
            }
        }


        /// <summary>
        /// Initialize all game objects and scene components.
        /// </summary>
        public virtual void Initialize()
        {
            if (!_initialized)
            {
                foreach (GameObject gameObject in gameObjects)
                {
                    gameObject.Initialize();

                    foreach (Component component in gameObject.Components)
                        UpdateComponents(component);
                }
            }
        }

        /// <summary>
        /// Update logic of game objects 2D and 3D.
        /// </summary>
        public virtual void Update()
        {
            foreach (Component component in _components)
            {
                if (component.GameObject.Enabled && component.Enabled)
                    component.Update();
            }
        }

        /// <summary>
        /// Draw the scene on screen.
        /// </summary>
        public virtual void Draw()
        {
            graphicsDevice.Clear(ClearColor);

            foreach (int index in _drawableComponents.Keys)
            {
                foreach (DrawableComponent drawable in _drawableComponents[index])
                {
                    if (drawable.GameObject.Enabled && drawable.Enabled)
                        drawable.Draw();
                }
            }
        }
    }
}
