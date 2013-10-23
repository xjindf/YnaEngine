using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Yna.Engine;
using Yna.Engine.Graphics2D;

namespace Yna.Engine.Winforms
{
    public abstract class YnGameControl : GraphicsDeviceControl
    {
        protected SpriteBatch spriteBatch;
        // TODO: Move GameTime here

        /// <summary>
        /// Initializes the control, creating the ContentManager
        /// and using it to load a SpriteFont.
        /// </summary>
        protected override void Initialize()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            YnG.Content = new ContentManager(Services, "Content"); ;
            YnG.GraphicsDevice = GraphicsDevice;
            YnG.StateManager = new StateManager(null);
        }

        /// <summary>
        /// Disposes the control, unloading the ContentManager.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                YnG.Content.Unload();

            base.Dispose(disposing);
        }
    }
}
