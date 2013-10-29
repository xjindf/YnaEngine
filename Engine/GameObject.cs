// YnaEngine - Copyright (C) YnaEngine team
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.
using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Yna.Engine
{
    public enum SceneLayer
    {
        Layer2D, Layer3D, GUI
    }

    /// <summary>
    /// Base class for all object on the Framework. A basic object is updateable
    /// </summary>
    public abstract class GameObject
    {
        #region Fields

        private static uint counterId = 0x0001;
        private uint _id;
        protected string _name;
        protected string _tag;
        protected SceneLayer _sceneLayer;
        protected bool _enabled;
        protected Transform _transform;
        protected List<GameObject> _children;
        protected List<Component> _components;
        protected List<DrawableComponent> _drawableComponents;

        #endregion

        #region Properties

        /// <summary>
        /// Get the unique identification code of this object
        /// </summary>
        public uint Id
        {
            get { return _id; }
            protected set { _id = value; }
        }

        /// <summary>
        /// Gets or Sets the name of this object
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets or sets the tag
        /// </summary>
        public string Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        public SceneLayer Layer
        {
            get { return _sceneLayer; }
            set { _sceneLayer = value; }
        }

        public Transform Transform
        {
            get { return _transform; }
            set { _transform = value; }
        }

        public List<GameObject> Children
        {
            get { return _children; }
            protected set { _children = value; }
        }

        /// <summary>
        /// Active or Desactive this object
        /// </summary>
        public bool Active
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        /// <summary>
        /// Pause or resume updates
        /// </summary>
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        #endregion

        public GameObject()
        {
            _id = counterId++;
            _name = String.Format("GameObject{0}", Id.ToString());
            _transform = new Transform(this);
            _tag = "Default";
            _sceneLayer = SceneLayer.Layer2D; // Deprecated, we'll use real layer soon
            _components = new List<Component>();
            _drawableComponents = new List<DrawableComponent>();
            _enabled = true;
        }

        public GameObject(Transform parent)
            : base()
        {
            _transform.Parent = parent;
        }

        /// <summary>
        /// Update method called on each engine update
        /// </summary>
        /// <param name="gameTime"></param>
        public abstract void Update(GameTime gameTime);

        public void Execute()
        {
            if (_enabled)
            {
                for (int i = 0; i < _components.Count; i++)
                {
                    if (_components[i].Enabled)
                        _components[i].Update();
                }

                for (int i = 0; i < _drawableComponents.Count; i++)
                {
                    if (_drawableComponents[i].Enabled)
                        _drawableComponents[i].Draw();
                }
            }
        }

        public void AddGameObject(GameObject gameObject)
        {
            gameObject.Transform.Parent = _transform;
            _children.Add(gameObject);
        }

        public void AddComponent(Component component)
        {
            _components.Add(component);

            if (component is DrawableComponent)
                _drawableComponents.Add(component as DrawableComponent);
        }

        public void RemoveGameObject(GameObject gameObject)
        {
            gameObject.Transform.Parent = null;
            _children.Remove(gameObject);
        }

        public void RemoveComponent(Component component)
        {
            _components.Remove(component);

            if (component is DrawableComponent)
                _drawableComponents.Remove(component as DrawableComponent);
        }

        public T GetComponent<T>() where T : class
        {
            object result = null;

            int i = 0;
            int counter = _components.Count;

            while (i < counter && result == null)
                result = (_components[i] is T) ? _components[i] : result;

            return (T)result;
        }
    }
}
