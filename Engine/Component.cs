using Microsoft.Xna.Framework.Graphics;

namespace Yna.Engine
{
    /// <summary>
    /// A component is a part of a game object. It's updated where at the same time of its game object.
    /// </summary>
    public abstract class Component
    {
        private bool _enabled = true;
        protected uint _order;
        protected GameObject _gameObject;

        /// <summary>
        /// Determine if the component is enabled of disabled.
        /// </summary>
        public bool Enabled 
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        /// <summary>
        /// Gets the game object of this component.
        /// </summary>
        public GameObject GameObject
        {
            get { return _gameObject; }
            protected set { _gameObject = value; }
        }

        public uint Order
        {
            get { return _order; }
            protected set { _order = value; }
        }

        /// <summary>
        /// Create an empty component.
        /// </summary>
        public Component()
        {
            _enabled = false;
            _gameObject = null;
        }

        /// <summary>
        /// Create a component attached to a game object.
        /// </summary>
        /// <param name="gameObject"></param>
        public Component(GameObject gameObject)
        {
            _enabled = true;
            _gameObject = gameObject;
            _order = 0;
        }

        /// <summary>
        /// Initialize the logic.
        /// </summary>
        public abstract void Initialize();

        /// <summary>
        /// This method is called before update loop.
        /// </summary>
        public virtual void BeforeUpdate()
        {
        }

        /// <summary>
        /// Update the logic.
        /// </summary>
        public abstract void Update();
    
        /// <summary>
        /// This method is called after update loop.
        /// </summary>
        public virtual void AfterUpdate()
        {
        }

        public int CompareTo(Component other)
        {
            if (this is DrawableComponent && !(other is DrawableComponent))
                return 1;
            else if (!(this is DrawableComponent) && other is DrawableComponent)
                return -1;
            else
                return 0;
        }

        public static int CompareTo(Component c1, Component c2)
        {
            return c1.CompareTo(c2);
        }
    }
}
