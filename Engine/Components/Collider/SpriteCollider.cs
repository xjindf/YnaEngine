using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Components.Collider
{
    public enum SpriteColliderMethod
    {
        Circle, Rectangle, Perfect
    }

    public class SpriteCollider : Component, ICollider
    {
        protected Rectangle boundingRect;
        protected Circle boundingCircle;
        private SpriteRenderer _cacheRenderer;
        private Transform _cacheTransform;
        private SpriteCollider _cacheCollider;
        private ICollider[] _colliders;
        private YnBehavior[] _scripts;

        private Vector2 _position;
        private Vector2 _distance;
        private Vector2 _direction;
        private Vector2 _lastPosition;
        private Vector2 _lastDistance;

        public SpriteColliderMethod CollideMethod { get; set; }

        public ColliderType ColliderType
        {
            get { return ColliderType.Two2D; }
        }

        public event EventHandler<SpriteColliderEventArgs> CollisionDetected = null;

        public SpriteCollider(GameObject gameObject)
            : base(gameObject)
        {
            _lastPosition = Vector2.Zero;
            _distance = Vector2.One;
            _lastDistance = Vector2.Zero;
            _direction = Vector2.Zero;
            _position = Vector2.Zero;
            CollideMethod = SpriteColliderMethod.Circle;
        }

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

            _colliders = (YnG.CurrentScene != null) ? YnG.CurrentScene.GetRenderableObjects(ColliderType.Two2D) : new ICollider[0];
            _scripts = GameObject.GetComponents<YnBehavior>();
        }

        public override void Update()
        {
            _position.X = _cacheTransform.Position.X;
            _position.Y = _cacheTransform.Position.Y;
            boundingRect.X = (int)_position.X;
            boundingRect.X = (int)_position.Y;
            boundingCircle.X = _position.X;
            boundingCircle.Y = _position.Y;
        }

        public override void LateUpdate()
        {
            DetectCollisions();
        }

        public virtual void UpdateSize()
        {
            boundingRect.Width = _cacheRenderer.Size.X;
            boundingRect.Height = _cacheRenderer.Size.Y;
            boundingCircle.Radius = Math.Max(boundingRect.Width, boundingRect.Height);
        }

        public void DetectCollisions()
        {
            foreach (ICollider collider in _colliders)
            {
                _cacheCollider = collider as SpriteCollider;
                if (_cacheCollider != null)
                {
                    bool collide = false;

                    if (CollideMethod == SpriteColliderMethod.Circle)
                        collide = Circle.Collide(boundingCircle, _cacheCollider.boundingCircle);
                    else
                        collide = boundingRect.Intersects(_cacheCollider.boundingRect);

                    if (collide)
                    {
                        _cacheTransform.Position = new Vector3(_lastPosition.X, _lastPosition.Y, _cacheTransform.Position.Z);

                        if (CollisionDetected != null)
                            CollisionDetected(this, new SpriteColliderEventArgs(_cacheCollider.GameObject));

                        foreach (YnBehavior behavior in _scripts)
                            behavior.OnCollisionEnter(collider);
                    }
                }
            }
        }
    }
}
