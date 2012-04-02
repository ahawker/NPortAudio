using System;
using System.Security;
using System.Runtime.InteropServices;

namespace NPortAudio.Native
{
    /// <summary>
    /// Static class for calling extern functions exposed by portaudio.dll
    /// </summary>
    /// <remarks>
    /// Full API docs can be found at: http://portaudio.com/docs/
    /// </remarks>
    [SuppressUnmanagedCodeSecurity]
    internal static class PortAudioApiNative
    {
        /// <summary>
        /// Retrieves the release number of the currently running PortAudio build.
        /// </summary>
        /// <returns>PortAudio Build.</returns>
        [DllImport(DllImports.PortAudio)]
        internal static extern int Pa_GetVersion();

        /// <summary>
        /// Retrieve a textual description of the current PortAudio build.
        /// </summary>
        /// <example>
        /// "PortAudio V19-devel 13 October 2002".
        /// </example>
        /// <returns>PortAudio Build version string.</returns>
        [DllImport(DllImports.PortAudio)]
        internal static extern IntPtr Pa_GetVersionText();

        /// <summary>
        /// Translate the supplied PortAudio error code into a human readable message.
        /// </summary>
        /// <param name="error">Error code to retrieve description of.</param>
        /// <returns>Description of given error.</returns>
        [DllImport(DllImports.PortAudio)]
        internal static extern IntPtr Pa_GetErrorText(PortAudioError error);
    }
}