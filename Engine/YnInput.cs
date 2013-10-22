using System;
using Yna.Engine.Input;

namespace Yna.Engine
{
    public class YnInput
    {
        /// <summary>
        /// Gets or Set the keyboard states
        /// </summary>
        public static YnKeyboard Keys { get; internal set; }

        /// <summary>
        /// Gets or Set the mouse states
        /// </summary>
        public static YnMouse Mouse { get; internal set; }

        /// <summary>
        /// Gets or Set the Gamepad states
        /// </summary>
        public static YnGamepad Gamepad { get; internal set; }

        /// <summary>
        /// Gets or Set the Touch states
        /// </summary>
        public static YnTouch Touch { get; internal set; }
    }
}