using Microsoft.Xna.Framework.Graphics;

namespace Yna.Engine
{
    /// <summary>
    /// A drawable component is used to draw something on screen. It can be a sprite, a mesh or GUI.
    /// </summary>
    public abstract class DrawableComponent : Component
    {
        protected SpriteBatch spriteBatch;
        protected GraphicsDevice graphics;

        /// <summary>
        /// Draw the component on screen.
        /// </summary>
        public abstract void Draw();
    }
}
