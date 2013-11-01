using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Linq;
using System.Collections.Generic;
using Yna.Engine.Components;
using Yna.Engine.Graphics2D;
using Yna.Engine.Graphics3D;
using Yna.Engine.Graphics3D.Camera;

namespace Yna.Engine.Scene
{
    public class Scene
    {
        private bool _initialized;

        protected List<GameObject> gameObjects;
        private List<GameObject> gameObjectsToAdd;
        private List<GameObject> gameObjectsToRemove;
        protected List<Component> components;
        private List<Component> colliders;
        private List<DrawableComponent> _spriteDrawables;
        private List<DrawableComponent> _commonDrawables;
        private List<DrawableComponent> _guiDrawables;
        private uint _componentsCount;
        private uint _spriteDrawablesCount;
        private uint _commonDrawablesCount;
        private uint _guiDrawablesCount;

        protected GraphicsDevice graphicsDevice;
        protected SpriteBatch spriteBatch;
        protected SceneSettings sceneSettings;

        public Color ClearColor = Color.Black;

        public event EventHandler<GameObjectChangedEventArgs> GameObjectAdded = null;
        public event EventHandler<GameObjectChangedEventArgs> GameObjectRemoved = null;

        protected void OnGameObjectChanged(GameObject gameObject, bool added)
        {
            if (added && GameObjectAdded != null)
                GameObjectAdded(this, new GameObjectChangedEventArgs(gameObject, true));
            else if (!added && GameObjectRemoved != null)
                GameObjectRemoved(this, new GameObjectChangedEventArgs(gameObject, false));
        }

        public string Name
        {
            get { return sceneSettings.Name; }
        }

        public Scene()
        {
            gameObjects = new List<GameObject>();
            gameObjectsToAdd = new List<GameObject>();
            gameObjectsToRemove = new List<GameObject>();

            components = new List<Component>();
            _spriteDrawables = new List<DrawableComponent>();
            _commonDrawables = new List<DrawableComponent>();
            _guiDrawables = new List<DrawableComponent>();
            _initialized = false;

            _componentsCount = 0;
            _spriteDrawablesCount = 0;
            _componentsCount = 0;
            _guiDrawablesCount = 0;

            sceneSettings = new SceneSettings();
        }

        public virtual void Add(GameObject gameObject)
        {
            if (_initialized)
                gameObjectsToAdd.Add(gameObject);
            else
                AddGameObject(gameObject);
        }

        public virtual void Remove(GameObject gameObject)
        {
            if (_initialized)
                gameObjectsToRemove.Add(gameObject);
            else
                RemoveGameObject(gameObject);
        }

        /// <summary>
        /// Add a 2D game object on the scene. It's initialized and loaded if it's not.
        /// </summary>
        /// <param name="gameObject">The game object to add.</param>
        private void AddGameObject(GameObject gameObject)
        {
            if (gameObjects.IndexOf(gameObject) == -1)
            {
                if (_initialized)
                    InitializeGameObject(gameObject);

                gameObjects.Add(gameObject);
            }
        }

        private void AddComponent(Component component)
        {
            if (components.IndexOf(component) == -1)
            {
                if (component is Camera && Camera.Main == null)
                    Camera.Main = component as Camera;

                else if (component is ICollider)
                    colliders.Add(component);

                components.Add(component);
                _componentsCount++;

                DrawableComponent drawable = component as DrawableComponent;

                if (drawable != null)
                {
                    drawable.GraphicsDevice = graphicsDevice;
                    drawable.SpriteBatch = spriteBatch;

                    switch (component.Layer)
                    {
                        case ComponentLayer.Layer2D:
                            _spriteDrawables.Add(drawable);
                            _spriteDrawablesCount++;
                            break;
                        case ComponentLayer.Layer3D:
                            _commonDrawables.Add(drawable);
                            _commonDrawablesCount++;
                            break;
                        case ComponentLayer.GUI:
                            _guiDrawables.Add(drawable);
                            _guiDrawablesCount++;
                            break;
                    }
                }
            }
        }

        private void RemoveComponent(Component component)
        {
            if (components.IndexOf(component) >= 0)
            {
                if (component is ICollider)
                    colliders.Remove(component);

                components.Remove(component);
                _componentsCount--;

                switch (component.Layer)
                {
                    case ComponentLayer.Layer2D:
                        _spriteDrawables.Remove(component as DrawableComponent);
                        _spriteDrawablesCount--;
                        break;
                    case ComponentLayer.Layer3D:
                        _commonDrawables.Remove(component as DrawableComponent);
                        _commonDrawablesCount--;
                        break;
                    case ComponentLayer.GUI:
                        _guiDrawables.Remove(component as DrawableComponent);
                        _guiDrawablesCount--;
                        break;
                }
            }
        }

        private void RemoveGameObject(GameObject gameObject)
        {
            if (gameObjects.IndexOf(gameObject) >= 0)
            {
                foreach (Component component in gameObject.Components)
                    RemoveComponent(component);

                gameObjects.Remove(gameObject);
            }
        }

        private void InitializeGameObject(GameObject gameObject)
        {
            gameObject.Initialize();

            foreach (Component component in gameObject.Components)
                AddComponent(component);
        }

        /// <summary>
        /// Initialize all game objects and scene components.
        /// </summary>
        public virtual void Initialize()
        {
            if (!_initialized)
            {
                foreach (GameObject gameObject in gameObjects)
                    InitializeGameObject(gameObject);

                _initialized = true;

                graphicsDevice = YnG.GraphicsDevice;
                spriteBatch = new SpriteBatch(graphicsDevice);
            }
        }

        /// <summary>
        /// Update logic of game objects 2D and 3D.
        /// </summary>
        public virtual void Update()
        {
            if (gameObjectsToRemove.Count > 0)
            {
                foreach (GameObject gameObject in gameObjectsToRemove)
                    RemoveGameObject(gameObject);

                gameObjectsToRemove.Clear();
            }

            if (gameObjectsToAdd.Count > 0)
            {
                foreach (GameObject gameObject in gameObjectsToAdd)
                    AddGameObject(gameObject);

                gameObjectsToAdd.Clear();
            }

            for (int i = 0; i < _componentsCount; i++)
            {
                if (components[i].GameObject.Enabled && components[i].Enabled)
                {
                    components[i].BeforeUpdate();
                    components[i].Update();
                }
            }

            for (int i = 0; i < _componentsCount; i++)
            {
                if (components[i].GameObject.Enabled && components[i].Enabled)
                    components[i].LateUpdate();
            }
        }

        /// <summary>
        /// Draw the scene on screen.
        /// </summary>
        public virtual void Draw()
        {
            graphicsDevice.Clear(ClearColor);

            int i = 0;

            // Draw 2D layer
            if (_spriteDrawablesCount > 0)
            {
                spriteBatch.Begin();

                for (i = 0; i < _spriteDrawablesCount; i++)
                {
                    if (_spriteDrawables[i].GameObject.Enabled && _spriteDrawables[i].Enabled)
                    {
                        _spriteDrawables[i].BeforeDraw();
                        _spriteDrawables[i].Draw();
                    }
                }

                spriteBatch.End();
            }

            // Draw 3D layer
            if (_commonDrawablesCount > 0)
            {
                i = 0;

                for (i = 0; i < _commonDrawablesCount; i++)
                {
                    if (_commonDrawables[i].GameObject.Enabled && _commonDrawables[i].Enabled)
                    {
                        _commonDrawables[i].BeforeDraw();
                        _commonDrawables[i].Draw();
                    }
                }
            }

            // Draw GUI layer
            if (_guiDrawablesCount > 0)
            {
                i = 0;

                spriteBatch.Begin();

                for (i = 0; i < _guiDrawablesCount; i++)
                {
                    if (_guiDrawables[i].GameObject.Enabled && _guiDrawables[i].Enabled)
                    {
                        _guiDrawables[i].BeforeDraw();
                        _guiDrawables[i].Draw();
                    }
                }

                spriteBatch.End();
            }
        }

        internal ICollider[] GetRenderableObjects(ColliderType colliderType)
        {
            List<DrawableComponent> list = (colliderType == ColliderType.Two2D) ? _spriteDrawables : _commonDrawables;
            List<ICollider> results = new List<ICollider>();

            foreach (DrawableComponent drawable in list)
            {
                if (drawable is ICollider)
                    results.Add(drawable as ICollider);
            }

            return results.ToArray();
        }
    }
}
