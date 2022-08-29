﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraNet.Shared.Network
{
    public interface IDatagram
    {
        byte Identifier { public get; set; }

        void Serialize();
        void Deserialize();
    }
}
