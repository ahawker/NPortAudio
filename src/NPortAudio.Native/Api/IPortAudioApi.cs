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
        /// <returns>PortAudio Build.</returns>
        int GetVersion();
    }
}