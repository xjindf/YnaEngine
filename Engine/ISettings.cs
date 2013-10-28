using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine
{
    /// <summary>
    /// An interface for settings.
    /// </summary>
    public interface ISettings
    {
        /// <summary>
        /// Load settings.
        /// </summary>
        void Load();

        /// <summary>
        /// Save settings.
        /// </summary>
        void Save();

        /// <summary>
        /// Clear settings.
        /// </summary>
        void Clear();
    }
}
