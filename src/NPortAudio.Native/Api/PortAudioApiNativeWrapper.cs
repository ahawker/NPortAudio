using System;
using System.Runtime.InteropServices;

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

        /// <summary>
        /// Retrieve a textual description of the current PortAudio build.
        /// </summary>
        /// <example>
        /// "PortAudio V19-devel 13 October 2002".
        /// </example>
        /// <returns>PortAudio Build version string.</returns>
        public string GetVersionText()
        {
            var ptr = PortAudioApiNative.Pa_GetVersionText();
            return Marshal.PtrToStringAnsi(ptr);
        }
    }
}