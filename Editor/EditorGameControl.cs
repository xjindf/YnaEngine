using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yna.Engine;
using Yna.Engine.Graphics2D;
using Yna.Engine.Winforms;

namespace Yna.Editor
{
    public class EditorGameControl : YnGameControl
    {
        public Color ClearColor;
        public Color DrawColor;
        Texture2D tex = null;
        int X;
        int Y;

        protected override void Initialize()
        {
            base.Initialize();

            tex = YnGraphics.CreateTexture(YnRandom.GetColor(), 50, 50);
            ClearColor = Color.AliceBlue;
            DrawColor = Color.Red;
            X = 50;
            Y = 50;
        }

        public void DrawAt(int x, int y)
        {
            DrawColor = YnRandom.GetColor();
            X = x;
            Y = y;
        }

        protected override void Draw()
        {
            GraphicsDevice.Clear(ClearColor);

            spriteBatch.Begin();
            spriteBatch.Draw(tex, new Rectangle(X, Y, 50, 50), DrawColor);
            spriteBatch.End();
        }
    }
}
