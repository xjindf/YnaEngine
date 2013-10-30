using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Components.Collider
{
    public class SpriteCollider : Component
    {
        protected Rectangle boundingRect;
        protected Circle boundingCircle;
        private SpriteRenderer _cacheRenderer;
        private Transform _cacheTransform;

        public override void Initialize()
        {
            _cacheRenderer = GameObject.GetComponent<SpriteRenderer>() as SpriteRenderer;
            _cacheTransform = GameObject.Transform;

            if (_cacheRenderer == null)
                throw new ComponentMissingException("[SpriteCollider] A SpriteRenderer must be added to this game object");

            boundingRect = new Rectangle(
                (int)_cacheTransform.Position.X,
                (int)_cacheTransform.Position.Y,
                _cacheRenderer.Size.X,
                _cacheRenderer.Size.Y);

            boundingCircle = new Circle(boundingRect.X, boundingRect.Y, Math.Max(boundingRect.Width, boundingRect.Height));
        }

        public override void Update()
        {
            boundingRect.X = (int)_cacheTransform.Position.X;
            boundingRect.X = (int)_cacheTransform.Position.Y;
            boundingCircle.X = boundingRect.X;
            boundingCircle.Y = boundingRect.Y;
        }

        public override void AfterUpdate()
        {
            
        }

        public virtual void UpdateSize()
        {
            boundingRect.Width = _cacheRenderer.Size.X;
            boundingRect.Height = _cacheRenderer.Size.Y;
            boundingCircle.Radius = Math.Max(boundingRect.Width, boundingRect.Height);
        }
    }
}
