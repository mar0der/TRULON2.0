using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trulon.Structs
{
    using global::Trulon.Enums;

    using Microsoft.Xna.Framework;

    public struct Obsticle
    {
        public BoundingBox ObsticleBox;

        public Direction RestrictedDirection;

        public Obsticle(int x, int y, int width, int height, Direction direction)
        {
            this.ObsticleBox = new BoundingBox(new Vector3(x, y, 0f), new Vector3(x + width, y + height, 0f));
            this.RestrictedDirection = direction;
        }

    }
}
