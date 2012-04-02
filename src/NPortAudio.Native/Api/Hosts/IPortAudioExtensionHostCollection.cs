namespace NPortAudio.Native
{
    public interface IPortAudioExtensionHostCollection
    {
        IPortAudioAlsaApi Alsa { get; }

        IPortAudioAsioApi Asio { get; }

        IPortAudioCoreAudioApi CoreAudio { get; }

        IPortAudioDirectSoundApi DirectSound { get; }

        IPortAudioJackApi Jack { get; }

        IPortAudioWasApi Was { get; }

        IPortAudioWdmApi Wdm { get; }

        IPortAudioWindowsApi Windows { get; }

        IPortAudioWmmeApi Wmme { get; }
    }
}