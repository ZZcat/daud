﻿namespace Game.Robots.Models
{
    using Game.API.Common;
    using System.Collections.Generic;
    using System.Numerics;

    public class Fleet
    {
        public string Name { get; set; }
        public uint ID { get; set; }
        public Sprites Sprite { get; set; }

        public List<Ship> Ships { get; set; } = new List<Ship>();

        public Vector2 Center
        {
            get
            {
                Vector2 acc = new Vector2(0, 0);

                foreach (var ship in Ships)
                    acc += ship.Position;

                if (Ships.Count > 0)
                    return acc / Ships.Count;
                else
                    return Vector2.Zero;
            }
        }

        public class Ship
        {
            public Vector2 Position { get; set; }
            public Vector2 Momentum { get; set; }
            public int Size { get; set; }
            public float Angle { get; set; }
        }
    }
}