using Microsoft.Xna.Framework.Graphics;

namespace Yna.Engine
{
    public abstract class DrawableComponent : Component
    {
        protected SpriteBatch spriteBatch;
        protected GraphicsDevice graphics;

        public abstract void Draw();
    }
}
