using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Components
{
    public class YnBehavior : Component
    {
        protected Transform transform;
        protected ICollider collider;
        protected IRenderer renderer;
        protected Camera camera;

        public override void Initialize()
        {
            transform = GameObject.Transform;
            camera = Camera.Main;
        }

        protected virtual void Start ()
        {
        }

        public override void Update()
        {
        }

        public virtual void OnCollisionEnter(ICollider collider)
        {
        }
    }
}
