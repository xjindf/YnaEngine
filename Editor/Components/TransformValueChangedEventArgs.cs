using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Editor.Components
{
    public class TransformValueChangedEventArgs : EventArgs
    {
        public string Property { get; private set; }
        public float Value { get; private set; }

        public TransformValueChangedEventArgs(string property, float value)
        {
            Property = property;
            Value = value;
        }
    }
}
