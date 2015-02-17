namespace Trulon.Structs
{
    using System;

    using Microsoft.Xna.Framework;

    /// <summary>
    /// Represents a 2D circle.
    /// </summary>
    struct Circle
    {
        /// <summary>
        /// Center position of the circle.
        /// </summary>
        public Vector2 Center;

        /// <summary>
        /// Radius of the circle.
        /// </summary>
        public float Radius;

        /// <summary>
        /// Constructs a new circle.
        /// </summary>
        public Circle(Vector2 position, float radius)
        {
            Center = position;
            Radius = radius;
        }

        /// <summary>
        /// Determines if a circle intersects a rectangle.
        /// </summary>
        /// <returns>True if the circle and rectangle overlap. False otherwise.</returns>
        //public bool Intersects(Rectangle rectangle)
        //{
        //    Vector2 v = new Vector2(MathHelper.Clamp(Center.X, rectangle.Left, rectangle.Right),
        //                            MathHelper.Clamp(Center.Y, rectangle.Top, rectangle.Bottom));

        //    Vector2 direction = Center - v;
        //    float distanceSquared = direction.LengthSquared();

        //    return ((distanceSquared > 0) && (distanceSquared < Radius * Radius));
        //}

        public bool intersects(Circle circle, BoundingBox bounds)
        {
            var isIntersects = false;
            
            return isIntersects;
        }

        private float CalculateDistance(Vector2 a, Vector2 b)
        {
            var distance = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
            return (float)distance;
        }
    }
}