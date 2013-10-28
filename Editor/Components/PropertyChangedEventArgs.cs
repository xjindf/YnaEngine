using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Editor.Components
{
    public class PropertyChangedEventArgs<T> : EventArgs
    {
        public T Value { get; protected set; }

        public PropertyChangedEventArgs(T property)
        {
            Value = property;
        }
    }
}
