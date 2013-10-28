using System;

namespace Yna.Editor.Components
{
    public class TransformValueChangedEventArgs : EventArgs
    {
        public string Property { get; protected set; }
        public string Axis { get; protected set; }
        public float Value { get; protected set; }

        public TransformValueChangedEventArgs(string property, string axis, float value)
        {
            Property = property;
            Axis = axis;
            Value = value;
        }
    }
}
