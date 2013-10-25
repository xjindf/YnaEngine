using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Editor.Components
{
    public class StringChangedEventArgs : EventArgs
    {
        public string Text { get; protected set; }

        public StringChangedEventArgs(string text)
        {
            Text = text;
        }
    }
}
