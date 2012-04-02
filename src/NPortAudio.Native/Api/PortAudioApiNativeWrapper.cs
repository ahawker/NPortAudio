using System;

namespace NPortAudio.Native
{
    internal sealed class PortAudioApiNativeWrapper : IPortAudioApi
    {
        public IPortAudioExtensionHostCollection Hosts
        {
            get { throw new NotImplementedException(); }
        }
    }
}