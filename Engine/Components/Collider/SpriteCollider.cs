using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Components.Collider
{
    public class SpriteCollider : Component
    {
        protected Rectangle boudingRect;
        protected Circle boundingCircle;
        private SpriteRenderer _spriteRendererCache;

        public override void Initialize()
        {
            _spriteRendererCache = GameObject.GetComponent<SpriteRenderer>() as SpriteRenderer;

            if (_spriteRendererCache == null)
                throw new ComponentMissingException("[SpriteCollider] A SpriteRenderer must be added to this game object");

            boudingRect = _spriteRendererCache.BoundingRect;
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
