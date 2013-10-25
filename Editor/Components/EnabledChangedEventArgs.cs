using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Editor.Components
{
    public class EnabledChangedEventArgs : EventArgs
    {
        public bool Enabled { get; protected set; }

        public EnabledChangedEventArgs(bool isEnabled)
        {
            Enabled = isEnabled;
        }
    }
}
