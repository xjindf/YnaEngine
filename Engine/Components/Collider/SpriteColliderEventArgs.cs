using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Components.Collider
{
    public class SpriteColliderEventArgs : EventArgs
    {
        public GameObject GameObject { get; protected set; }

        public SpriteColliderEventArgs(GameObject gameObject)
        {
            GameObject = gameObject;
        }
    }
}
