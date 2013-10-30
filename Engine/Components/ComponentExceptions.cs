using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Components
{
    public class ComponentMissingException : Exception
    {
        public ComponentMissingException(string message)
            : base(message)
        {
        }
    }
}
