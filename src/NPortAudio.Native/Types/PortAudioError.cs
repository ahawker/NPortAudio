namespace NPortAudio.Native
{
    public enum PortAudioError
    {
        NoError = 0,
        NotInitialized = -10000,
        UnanticipatedHostError,
        InvalidChannelCount,
        InvalidSampleRate,
        InvalidDevice,
        InvalidFlag,
        SampleFormatNotSupported,
        BadIoDeviceCombination,
        InsufficientMemory,
        BufferTooBig,
        BufferTooSmall,
        NullCallback,
        BadStreamPtr,
        TimedOut,
        InternalError,
        DeviceUnavailable,
        IncompatibleHostApiSpecificStreamInfo,
        StreamIsStopped,
        StreamIsNotStopped,
        InputOverflowed,
        OutputOverflowed,
        HostApiNotFound,
        InvalidHostApi,
        CanNotReadFromACallbackStream,
        CanNotWriteToACallbackStream,
        CanNotReadFromAnOutputOnlyStream,
        CanNotWriteToAnInputOnlyStream,
        IncompatableStreamHostApi,
        BadBufferPtr
    }
}