using System;

using OpenTK;

namespace GameObjects
{
    public class Transform2D : Object
    {
        private Vector2 position;
        private Vector2 rotation;
        private Vector2 scale;

        public Transform2D()
            : base()
        {
            position = Vector2.Zero;
            rotation = Vector2.Zero;
            scale = Vector2.One;
        }

        public Vector2 Position
        {
            get => position;

            set => position = value;
        }

        public Vector2 Rotation
        {
            get => rotation;

            set => rotation = value;
        }

        public Vector2 Scale
        {
            get => scale;

            set => scale = value;
        }
    }
}
