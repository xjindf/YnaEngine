using Microsoft.Xna.Framework.Graphics;

namespace Yna.Engine
{
    /// <summary>
    /// A component is a part of a game object. It's updated where at the same time of its game object.
    /// </summary>
    public abstract class Component
    {
        private bool _enabled = true;

        /// <summary>
        /// Determine if the component is enabled of disabled
        /// </summary>
        public bool Enabled 
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        /// <summary>
        /// Initialize the logic.
        /// </summary>
        public abstract void Initialize();

        /// <summary>
        /// Update the logic.
        /// </summary>
        public abstract void Update();
    }
}
