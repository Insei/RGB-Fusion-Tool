﻿// Copyright (C) 2018 Tyler Szabo
//
// This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Drawing;

namespace GLedApiDotNet.LedSettings
{
    public class DigitalF : LedSetting
    {
        public DigitalF(byte maxBrightness, byte minBrightness, ushort speed)
        {
            this.Mode = Modes.DigitalModeF;

            this.SetBrightness(maxBrightness, minBrightness);

            this.Time0 = speed;
        }

        public DigitalF(byte maxBrightness, byte minBrightness, TimeSpan speed)
            : this(maxBrightness, minBrightness, 0)
        {
            this.TimeSpan0 = speed;
        }

        public TimeSpan Speed => TimeSpan0;

        public override string ToString()
        {
            return string.Format("DigitalF: MaxBrightness={0}, MinBrightness={1}, Speed={2}s", MaxBrightness, MinBrightness, Speed.TotalSeconds);
        }
    }
}