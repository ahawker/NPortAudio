using System;

namespace NPortAudio.Native
{
    /// <summary>
    /// Interface class which handles marshalling between public api and extern native functions from PortAudio.
    /// </summary>
    internal sealed class PortAudioApiNativeWrapper : IPortAudioApi
    {
        /// <summary>
        /// Collection of non-portable extension host api's.
        /// </summary>
        public IPortAudioExtensionHostCollection Hosts
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Retrieves the release number of the currently running PortAudio build.
        /// </summary>
        /// <returns>PortAudio Build.</returns>
        public int GetVersion()
        {
            return PortAudioApiNative.Pa_GetVersion();
        }
    }
}