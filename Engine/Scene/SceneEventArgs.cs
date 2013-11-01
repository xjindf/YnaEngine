using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Scene
{
    public class GameObjectChangedEventArgs : EventArgs
    {
        public GameObject GameObject { get; protected set; }
        public bool Added { get; protected set; }

        public GameObjectChangedEventArgs(GameObject go, bool isAnAdd)
        {
            GameObject = go;
            Added = isAnAdd;
        }
    }
}
