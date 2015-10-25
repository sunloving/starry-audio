using System;
using NAudio.Wave;
using Starry.Audio.Core.Domain.SignalTypes;
using Starry.Audio.Core.Services.NaudioSpecific.WaveProviders;

namespace Starry.Audio.Core.Services.SignalGenerators.SignalGenerationStrategies
{
    internal class SinGenerationStrategy : ISignalGenerationStrategy<SinSignalType>
    {
        private readonly IWaveProvider waveProvider;

        public SinGenerationStrategy()
        {
            waveProvider = new SineWaveProvider32();
        }

        public int FillBuffer(byte[] buffer, int offset, int sampleCount)
        {
            return waveProvider.Read(buffer, offset, )
        }
    }
}