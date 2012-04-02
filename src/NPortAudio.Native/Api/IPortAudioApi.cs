namespace NPortAudio.Native
{
    /// <summary>
    /// Public Api exposed by PortAudio containing cross-platform Api and extension Host Api's.
    /// </summary>
    public interface IPortAudioApi
    {
        /// <summary>
        /// Collection of non-portable extension host api's.
        /// </summary>
        IPortAudioExtensionHostCollection Hosts { get; }

        /// <summary>
        /// Retrieves the release number of the currently running PortAudio build.
        /// </summary>
        /// <example>
        /// 1900
        /// </example>
        /// <returns>PortAudio Build.</returns>
        int GetVersion();

        /// <summary>
        /// Retrieve a textual description of the current PortAudio build.
        /// </summary>
        /// <example>
        /// "PortAudio V19-devel 13 October 2002".
        /// </example>
        /// <returns>PortAudio Build version string.</returns>
        string GetVersionText();
    }
}