using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Editor.Components
{
    public class TransformChangedEventArgs : EventArgs
    {
        public string Property { get; protected set; }
        public string Axis { get; protected set; }
        public float Value { get; protected set; }

        public TransformChangedEventArgs(string property, string axis, float value)
        {
            Property = property;
            Axis = axis;
            Value = value;
        }
    }
}
