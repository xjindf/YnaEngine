using Microsoft.Xna.Framework.Graphics;

namespace Yna.Engine
{
    public abstract class Component
    {
        public bool Enabled { get; set; }

        public Component()
        {
            Enabled = true;
        }

        public abstract void Initialize();

        public abstract void Update();
    }
}
