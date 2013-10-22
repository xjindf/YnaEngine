#region File Description
//-----------------------------------------------------------------------------
// SpriteFontControl.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Yna.Engine;
using Yna.Engine.Graphics;
using Yna.Engine.State;


namespace WinFormsGraphicsDevice
{
    /// <summary>
    /// Example control inherits from GraphicsDeviceControl, which allows it to
    /// render using a GraphicsDevice. This control shows how to use ContentManager
    /// inside a WinForms application. It loads a SpriteFont object through the
    /// ContentManager, then uses a SpriteBatch to draw text. The control is not
    /// animated, so it only redraws itself in response to WinForms paint messages.
    /// </summary>
    class EditorControl : GraphicsDeviceControl
    {
        ContentManager content;
        SpriteBatch spriteBatch;
        SpriteFont font;

        Texture2D tex;

        /// <summary>
        /// Initializes the control, creating the ContentManager
        /// and using it to load a SpriteFont.
        /// </summary>
        protected override void Initialize()
        {
            content = new ContentManager(Services, "Content");
            spriteBatch = new SpriteBatch(GraphicsDevice);

            tex = new Texture2D(GraphicsDevice, 50, 50);
            Color[] c = new Color[50 * 50];
            for (int i = 0; i < c.Length; i++)
                c[i] = Color.Red;
            tex.SetData<Color>(c);
        }


        /// <summary>
        /// Disposes the control, unloading the ContentManager.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                content.Unload();
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Draws the control, using SpriteBatch and SpriteFont.
        /// </summary>
        protected override void Draw()
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(tex, new Rectangle(25, 25, 100, 100), Color.White);
            spriteBatch.End();
        }
    }
}
