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
        /// Gets or sets the graphics device used to render 3D elements.
        /// </summary>
        public GraphicsDevice GraphicsDevice
        {
            get { return graphics; }
            set { graphics = value; }
        }

        /// <summary>
        /// Gets or sets the sprite batch used to render 2D elements.
        /// </summary>
        public SpriteBatch SpriteBatch
        {
            get { return spriteBatch; }
            set { spriteBatch = value; }
        }

        /// <summary>
        /// Create an empty drawable component.
        /// </summary>
        public DrawableComponent()
            : base()
        {
            Layer = ComponentLayer.Layer3D;
        }

        /// <summary>
        /// Create a drawable component attached to a game object.
        /// </summary>
        /// <param name="gameObject"></param>
        public DrawableComponent(GameObject gameObject)
            : base(gameObject)
        {
         
        }

        /// <summary>
        /// This method is called before draw loop.
        /// </summary>
        public virtual void BeforeDraw()
        {
        }

        /// <summary>
        /// Draw the component on screen.
        /// </summary>
        public abstract void Draw();
    }
}
