﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    public class MapBox : MapObject
    {
        public string Type = @"box";
        public MapBox(double x, double y, double z, double w, double h, double d)
            : base(x, y, z)
        {
            Width = w;
            Height = h;
            Depth = d;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
    }
}