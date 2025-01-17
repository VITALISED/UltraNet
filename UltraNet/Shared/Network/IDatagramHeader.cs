﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraNet.Shared.Network
{
    public interface IDatagramHeader
    {
        long TransmissionTime { get; } // replace with ticks later perhaps?
        byte SequenceNumber { get; }
        bool IsLastInSequence { get; }
        byte Channel { get; }

        void Serialize(BinaryWriter writer);
        void Deserialize(BinaryReader reader);
    }
}
