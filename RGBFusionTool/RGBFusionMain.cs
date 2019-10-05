﻿// Copyright (C) 2018 Tyler Szabo
//
// This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>.

using GLedApiDotNet;
using GvLedLibDotNet;
using System;

namespace RGBFusionTool
{
    public sealed class RGBFusionMain
    {
        private static int Main(string[] args)
        {
            Application application = new Application(
                () => new RGBFusionMotherboard(),
                () => new RGBFusionPeripherals(),
                Console.Out,
                Console.Error
            );

            try
            {
                application.Main(args);
            }
            catch
            {
                return 1;
            }

            return 0;
        }
    }
}