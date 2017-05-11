﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fantome.League.IO.WGEO;
using Fantome.League.IO.MOB;
using Fantome.League.IO.SKN;
using Fantome.League.IO.FX;

namespace Fantome.League.Tests
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void WGEOTest()
        {
            WGEOFile wgeo = new WGEOFile("room.wgeo");
            wgeo.Write("roomWrite.wgeo");
        }
        static void MOBTest()
        {
            MOBFile mob = new MOBFile("MapObjects.mob");
            mob.Write("MapObjectsWrite.mob");
        }
        static void SKNTest()
        {
            SKNFile skn = new SKNFile("Gangplank_Skin08.skn");
        }
        static void FXTest()
        {
            FXFile fx = new FXFile("KalistaPChannel.fx");
            fx.Write("KalistaPChannelWrite.fx");
        }
    }
}
