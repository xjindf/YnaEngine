// YnaEngine - Copyright (C) YnaEngine team
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.
using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Yna.Engine.Components
{
    public class Transform : Component
    {
        private Matrix _world;
        private Vector3 _rotation;
        private Vector3 _position;
        private Vector3 _scale;
        private Transform _parent;
        protected List<Transform> _transforms;

        public Transform Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        public List<Transform> Transforms
        {
            get { return _transforms; }
            protected set { _transforms = value; }
        }

        public Vector3 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Vector3 Rotation
        {
            get { return _rotation; }
            set { _rotation = value; }
        }

        public Vector3 Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }

        public Matrix WorldMatrix
        {
            get { return _world; }
        }

        public Transform(GameObject gameObject)
            : base (gameObject)
        { 
            Initialize();
            _parent = gameObject.Transform.Parent;
        }

        public override void Initialize()
        {
            _position = Vector3.Zero;
            _rotation = Vector3.Zero;
            _scale = Vector3.Zero;
            _world = Matrix.Identity;
            _parent = null;
            _transforms = new List<Transform>();
        }

        public void Translate(float x, float y, float z)
        {
            Vector3 move = new Vector3(x, y, z);
            Matrix forwardMovement = Matrix.CreateRotationY(_rotation.Y);
            Vector3 tVector = Vector3.Transform(move, forwardMovement);
            _position += tVector;
        }

        public void Rotate(float rx, float ry, float rz)
        {
            _rotation.X = rx;
            _rotation.Y = ry;
            _rotation.Z = rz;
        }

        public void Turn(float rx, float ry, float rz)
        {
            _rotation.X += rx;
            _rotation.Y += ry;
            _rotation.Z += rz;
        }

        public void Scaling(float sx, float sy, float sz)
        {
            _scale.X = sx;
            _scale.Y = sy;
            _scale.Z = sz;
        }

        public override void Update()
        {
            // Set the matrix world to identify
            _world = Matrix.Identity;

            _world *= Matrix.CreateScale(_scale);

            // If a parent exists
            if (_parent != null)
            {
                _world = _parent.WorldMatrix;
                _world *= Matrix.CreateFromAxisAngle(_parent.WorldMatrix.Right, _rotation.X);
                _world *= Matrix.CreateFromAxisAngle(_parent.WorldMatrix.Up, _rotation.Y);
                _world *= Matrix.CreateFromAxisAngle(_parent.WorldMatrix.Forward, _rotation.Z);
            }
            // Local transforms
            else
            {
                _world *= Matrix.CreateFromYawPitchRoll(_rotation.Y, _rotation.X, _rotation.Z);
            }

            _world *= Matrix.CreateTranslation(_position);
        }
    }
}
