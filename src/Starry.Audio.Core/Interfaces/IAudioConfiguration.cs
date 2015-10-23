﻿using Starry.Audio.Core.Enums.Configuration;

namespace Starry.Audio.Core.Interfaces
{
    public interface IAudioConfiguration
    {
        BitDepthMode BitDepthMode { get; }

        SampleRateMode SampleRateMode { get; }

        bool IsStereo { get; }

        byte ChannelsCount { get; }
    }
}