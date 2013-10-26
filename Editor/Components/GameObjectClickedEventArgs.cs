using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yna.Engine;

namespace Yna.Editor.Components
{
    public class GameObjectClickedEventArgs : EventArgs
    {
        public GameObject GameObject { get; set; }

        public GameObjectClickedEventArgs(GameObject go)
        {
            GameObject = go;
        }
    }
}
