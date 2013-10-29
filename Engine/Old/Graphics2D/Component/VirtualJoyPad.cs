using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Graphics2D.Component
{
    struct VirtualJoyPadButton
    {
        public Vector2 Position;
        public Rectangle SourceRect;
        public Rectangle Rect;
        public bool Enabled;
        public bool Hovered;

        public void ComputeRect()
        {
            Rect = new Rectangle((int)Position.X, (int)Position.Y, SourceRect.Width, SourceRect.Height);
        }
    }

    public enum JoyPadButton
    {
        LeftThumbStick = 0, RightThumbStick, A, B, X, Y
    }

    public class JoyPadButtonHovered : EventArgs
    {
        public JoyPadButton Button { get; protected set; }

        public JoyPadButtonHovered(JoyPadButton button)
        {
            Button = button;
        }
    }

    public class VirtualJoyPad : YnSprite
    {
        private Vector2 _padding;
        private Vector2 _margin;
        private float _radius;
        private VirtualJoyPadButton[] _padButtons;

        public bool this[int index]
        {
            get 
            {
                if (index < 0 && index >= 6)
                    throw new ArgumentOutOfRangeException();

                return _padButtons[index].Hovered;
            }
            protected set
            {
                _padButtons[index].Hovered = value;
            }
        }

        public event EventHandler<JoyPadButtonHovered> JoyPadButtonHover = null;

        private void OnJoyPadButtonHover(int index)
        {
            if (JoyPadButtonHover != null)
                JoyPadButtonHover(this, new JoyPadButtonHovered((JoyPadButton)index));
        }

        public VirtualJoyPad(GameObject parent)
            : base()
        {
            _assetName = "JoyPadTexture";
            _padButtons = new VirtualJoyPadButton[6];
            _padding = new Vector2(5.0f);
            _margin = new Vector2(30.0f, 30.0f);
            _radius = 25;
        }

        public override void LoadContent()
        {
            base.LoadContent();
            _padButtons = new VirtualJoyPadButton[6];

            ComputeJoyPad();

            _padButtons[1].Enabled = false;
        }

        public void ComputeJoyPad()
        {
            Vector2[] positions = new Vector2[6];
            Rectangle[] sourceRect = new Rectangle[6];

            sourceRect[0] = new Rectangle(2, 2, 68, 68);  // Left thumbstick
            sourceRect[1] = new Rectangle(2, 70, 68, 68); // Right thumbstick
            sourceRect[2] = new Rectangle(72, 114, 36, 36);  // Button A
            sourceRect[3] = new Rectangle(72, 77, 36, 36); // Button B
            sourceRect[4] = new Rectangle(72, 40, 36, 36); // Button X
            sourceRect[5] = new Rectangle(72, 3, 36, 36); // Button Y

            int sizeOfButton = 36;
            positions[0] = new Vector2(_margin.X, YnScreen.Height - sourceRect[0].Height - _margin.Y);
            positions[1] = new Vector2();
            positions[2] = new Vector2(YnScreen.Width - _margin.X - (sizeOfButton * 2), YnScreen.Height - _margin.Y - sizeOfButton);
            positions[3] = new Vector2(YnScreen.Width - _margin.X - sizeOfButton, positions[2].Y - sizeOfButton);
            positions[4] = new Vector2(YnScreen.Width - _margin.X - (sizeOfButton * 3), positions[2].Y - sizeOfButton);
            positions[5] = new Vector2(positions[2].X, YnScreen.Height - _margin.Y - (3 * sizeOfButton));

            for (int i = 0; i < 6; i++)
            {
                _padButtons[i].Position = positions[i];
                _padButtons[i].SourceRect = sourceRect[i];
                _padButtons[i].Enabled = true;
                _padButtons[i].ComputeRect();
            }
        }

        public override void Update(GameTime gameTime)
        {
            for (int i = 0; i < 6; i++)
            {
                _padButtons[i].Hovered = (_padButtons[i].Rect.Contains(YnInput.Mouse.Position));

                if (i >= 2 && _padButtons[i].Hovered)
                    OnJoyPadButtonHover(i);

                else if (i < 2 && _padButtons[i].Hovered)
                {
                    var delta = YnInput.Mouse.Delta;

                    _padButtons[i].Position.X += delta.X;
                    _padButtons[i].Position.Y += delta.Y;
                }
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            for (int i = 0; i < 6; i++)
            {
                if (_padButtons[i].Enabled)
                    spriteBatch.Draw(_texture, _padButtons[i].Position, _padButtons[i].SourceRect, _color * _alpha, 0.0f, Vector2.Zero, _scale, SpriteEffects.None, _layerDepth);
            }
        }
    }
}
