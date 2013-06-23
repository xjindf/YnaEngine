﻿// YnaEngine - Copyright (C) YnaEngine team
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

namespace Yna.Engine.Graphics.Gui.Widgets
{
    /// <summary>
    /// Base class for all kinds of buttons.
    /// </summary>
    public abstract class YnButton : YnPanel
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public YnButton()
            : base()
        {
            _padding = 10;
            _hasBackground = true;
            _animated = true;
        }
    }
}
