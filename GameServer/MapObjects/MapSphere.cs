﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GameServer.MapObjects
{
    public class MapSphere : MapObject
    {

        public MapSphere(float x, float y, float z, float diameter, MapObject parent = null, Color color = null, int texture = 0)
            : base(x, y, z, parent, color, texture)
        {
            Diameter = diameter;
        }

        public MapSphere(Vector3 pos, float diameter, MapObject parent = null, Color color = null, int texture = 0)
            : base(pos.X, pos.Y, pos.Z, parent, color, texture)
        {
            Diameter = diameter;
        }


        public float Diameter { get; set; }

        [JsonIgnore]
        public float Radius
        {
            get
            {
                return Diameter / 2f;
            }
            set
            {
                Diameter = value * 2f;
            }
        }

        [JsonIgnore]
        public float RadiusSquared
        {
            get
            {
                return (float)Math.Pow(Radius, 2);
            }
        }


    }
}
