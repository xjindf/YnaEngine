// YnaEngine - Copyright (C) YnaEngine team
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.
using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Yna.Engine.Components;

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

        private Guid _guid = Guid.NewGuid();
		private Dictionary<Type, Component> _componentsCache;
        private List<Component> _components;
        private List<DrawableComponent> _drawableComponents;
        
        protected bool enabled;
        protected string name;
        protected string tag;
        protected SceneLayer sceneLayer;
        protected List<GameObject> children;
        protected Transform transform;
		
        #endregion

        #region Properties

        /// <summary>
        /// Get the unique identification code of this object
        /// </summary>
        public Guid Uid
        {
            get { return _guid; }
        }

        /// <summary>
        /// Gets or Sets the name of this object
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the tag
        /// </summary>
        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        public SceneLayer Layer
        {
            get { return sceneLayer; }
            set { sceneLayer = value; }
        }

        public List<GameObject> Children
        {
            get { return children; }
            protected set { children = value; }
        }
		
		public List<Component> Components
		{
			get { return _components; }
			internal set { _components = value; }
		}

        public Transform Transform
        {
            get { return transform; }
            protected set { transform = value; }
        }

        /// <summary>
        /// Active or Desactive this object
        /// </summary>
        public bool Active
        {
            get { return enabled; }
            set { enabled = value; }
        }

        /// <summary>
        /// Pause or resume updates
        /// </summary>
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        #endregion

        public GameObject()
        {
            name = "Game Object";
            tag = "Default";
            enabled = true;
			sceneLayer = SceneLayer.Layer2D; // Deprecated, we'll use real layer soon
            _components = new List<Component>();
            _drawableComponents = new List<DrawableComponent>();
			_componentsCache = new Dictionary<Type, Component>();
            transform = new Transform(this);
            AddComponent(transform);
		}

        public GameObject(Transform parent)
            : base()
        {
            transform.Parent = parent;
        }

        /// <summary>
        /// Update method called on each engine update
        /// </summary>
        /// <param name="gameTime"></param>
        public abstract void Update(GameTime gameTime);

        #region game object management

        /// <summary>
        /// Change the parent of the game object.
        /// </summary>
        /// <param name="gameObject"></param>
        public void SetParent(GameObject gameObject)
        {
            gameObject.Transform.Parent = gameObject.Transform;
        }

        /// <summary>
        /// Add a game object to the children.
        /// </summary>
        /// <param name="gameObject">The game object to add.</param>
        /// <returns>Return true if the game object has been added, otherwise return false.</returns>
        public bool AddGameObject(GameObject gameObject)
        {
            bool exist = (children.IndexOf(gameObject) >= 0);
            
            if (!exist)
            {
                gameObject.SetParent(this);
                children.Add(gameObject);
            }

            return exist;
        }
		
        /// <summary>
        /// Remove a game object of the children.
        /// </summary>
        /// <param name="gameObject">The game object to remove.</param>
        /// <returns>Return true if the game object has been removed, otherwise return false.</returns>
		public bool RemoveGameObject(GameObject gameObject)
        {
            gameObject.SetParent(null);
            return children.Remove(gameObject);
        }

        #endregion

        #region Components management

        /// <summary>
        /// Add a component.
        /// </summary>
        /// <param name="component">The component to add.</param>
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

        /// <summary>
        /// Remove a component.
        /// </summary>
        /// <param name="component">The component to remove.</param>
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

        /// <summary>
        /// Gets the first component of type T in this game object.
        /// </summary>
        /// <typeparam name="T">Type of component.</typeparam>
        /// <returns>Return the component of type T if exists, otherwise return null.</returns>
        public Component GetComponent<T>()
        {
            Type type = typeof(T);
            if (_componentsCache.ContainsKey(type))
                return _componentsCache[type];
			
			return null;
        }

        /// <summary>
        /// Get components of type T in this game object.
        /// </summary>
        /// <typeparam name="T">Type of component.</typeparam>
        /// <returns>Return an array of components of type T if exists, otherwise return an empty array</returns>
        public Component[] GetComponents<T>() where T : class
        {
            Type type = typeof(T);
            List<Component> results = new List<Component>();
            
            foreach (Component component in _components)
            {
                if (component.GetType() == type)
                    results.Add(component as Component);
            }

            return results.ToArray();
        }

        /// <summary>
        /// Gets the first component of type T in children.
        /// </summary>
        /// <typeparam name="T">Type of component.</typeparam>
        /// <returns>Return the component of type T if exists, otherwise return null.</returns>
        public Component GetComponentInChildren<T>() where T : class
        {
            Type type = typeof(T);
            Component result = null;

            int i = 0;
            int size = children.Count;

            while (i < size && result == null)
            {
                result = children[i].GetComponent<T>();
                i++;
            }

            if (_componentsCache.ContainsKey(type))
                return _componentsCache[type];

            return null;
        }

        /// <summary>
        /// Get components of type T in children.
        /// </summary>
        /// <typeparam name="T">Type of component.</typeparam>
        /// <returns>Return an array of components of type T if exists, otherwise return an empty array</returns>
        public Component[] GetComponentsInChildren<T>() where T : class
        {
            Type type = typeof(T);

            List<Component> results = new List<Component>();
            Component component = null;

            foreach (GameObject go in Children)
            {
                component = go.GetComponent<T>();

                if (component != null)
                    results.Add(component);
            }

            return results.ToArray();
        }

        #endregion
    }
}
