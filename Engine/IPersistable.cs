namespace Yna.Engine
{
    /// <summary>
    /// An interface for settings.
    /// </summary>
    public interface IPersistable
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
