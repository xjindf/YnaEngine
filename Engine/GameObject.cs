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
		protected bool _enabled;
        protected string _name;
        protected string _tag;
        protected SceneLayer _sceneLayer;
		private Dictionary<Type, Component> _componentsCache;
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

        public List<GameObject> Children
        {
            get { return _children; }
            protected set { _children = value; }
        }
		
		public List<Component> Components
		{
			get { return _components; }
			internal set { _components = value; }
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
            _tag = "Default";
            _enabled = true;
			_sceneLayer = SceneLayer.Layer2D; // Deprecated, we'll use real layer soon
            _components = new List<Component>();
            _drawableComponents = new List<DrawableComponent>();
			_componentsCache = new Dictionary<Type, Component>();
			AddComponent(new Transform(this));
		}

        public GameObject(Transform parent)
            : base()
        {
            GetComponent<Transform>().Parent = parent;
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

        public void SetParent(GameObject gameObject)
        {
            throw new NotImplementedException();
        }

        public void AddGameObject(GameObject gameObject)
        {
            gameObject.SetParent(this);
            _children.Add(gameObject);
        }
		
		public void RemoveGameObject(GameObject gameObject)
        {
            gameObject.SetParent(null);
            _children.Remove(gameObject);
        }

        public void AddComponent(Component component)
        {
            Type type = component.GetType();
			if (_componentsCache.ContainsKey(type))
				return;
	
			_componentsCache.Add(type, component); 
            _components.Add(component);
	
            if (component is DrawableComponent)
                _drawableComponents.Add(component as DrawableComponent);
        }

        public void RemoveComponent(Component component)
        {
            Type type = component.GetType();
			if (!_componentsCache.ContainsKey(type) || component is Transform)
				return;
			
			_componentsCache.Remove(type);
            _components.Remove(component);

            if (component is DrawableComponent)
                _drawableComponents.Remove(component as DrawableComponent);
        }

        public T GetComponent<T>() where T : class
        {
            Type type = typeof(T);
            if (_componentsCache.ContainsKey(type))
                return _componentsCache[type] as T;
			
			return default(T);
        }

        public T GetComponentInChildren<T>() where T : class
        {
            Type type = typeof(T);

            object result = null;
            int i = 0;
            int size = _children.Count;

            while (i < size && result == null)
            {
                result = _children[i].GetComponent<T>();
                i++;
            }

            if (_componentsCache.ContainsKey(type))
                return _componentsCache[type] as T;

            return default(T);
        }
    }
}
