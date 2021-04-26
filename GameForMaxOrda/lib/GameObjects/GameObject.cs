using System;

namespace GameObjects
{
    public class GameObject : Object
    {
        private Transform2D transform;

        public GameObject()
            : base()
        {
        }

        public Transform2D Transform => transform;
    }
}
