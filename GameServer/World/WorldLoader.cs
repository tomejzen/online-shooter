﻿using GameServer.MapObjects;
using GameServer.States;
using System.Collections.Generic;

namespace GameServer.World
{
    public static class WorldLoader
    {
        public static void LoadMap()
        {
            var objs = new List<MapObject>
            {
                new MapBox(0, -1, 0, 30, 0.1, 30),
                new MapBox(-14, 3, -14, 1, 1, 1),
                new MapBox(14, 3, -14, 1, 1, 1),
                new MapBox(-14, 3, 14, 1, 1, 1),
                new MapBox(14, 3, 14, 1, 1, 1),
                new MapBox(14, 2, 0, 1, 3, 1),
                new MapBox(14, 2, 7, 1, 2, 1),
                new MapBox(14, 2, -7, 1, 2, 1),
                new MapBox(-14, 2, 0, 1, 3, 1),
                new MapBox(-14, 2, 7, 1, 2, 1),
                new MapBox(-14, 2, -7, 1, 2, 1),
                new MapBox(0, 2, 14, 1, 3, 1),
                new MapBox(7, 2, 14, 1, 2, 1),
                new MapBox(-7, 2, 14, 1, 2, 1),
                new MapBox(0, 2, -14, 1, 3, 1),
                new MapBox(7, 2, -14, 1, 2, 1),
                new MapBox(-7, 2, -14, 1, 2, 1),
            };

            MapState.Instance.MapObjects.AddRange(objs);
        }

    }
}
