using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Editor.Components
{
    public class TransformChangedEventArgs : EventArgs
    {
        public Vector3 [] Transform { get; protected set; }

        public TransformChangedEventArgs(Vector3 position, Vector3 rotation, Vector3 scale)
        {
            Transform = new Vector3[3];
            Transform[0] = position;
            Transform[1] = rotation;
            Transform[2] = scale;
        }
    }
}
