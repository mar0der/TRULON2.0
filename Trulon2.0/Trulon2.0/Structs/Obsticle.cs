namespace Trulon.Structs
{
    using Microsoft.Xna.Framework;
    using global::Trulon.Enums;

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
