using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Components
{
    public enum CameraProjectionType
    {
        Perspective = 0, Orthographic
    }

    /// <summary>
    /// The camera component is designed to be used with a renderer and a scene.
    /// </summary>
    public class Camera : Component
    {
        #region Fields

        CameraProjectionType _projectionType = CameraProjectionType.Perspective;

        // Matrix
        protected Matrix _projection;
        private bool _needProjectUpdate;
        protected Matrix _view;

        // View parameters
        protected float _fieldOfView;
        protected float _aspectRatio;
        protected float _nearPlane;
        protected float _farPlane;

        // target, placement
        protected Vector3 _reference;
        protected Transform _target;
        protected Vector3 _upVector;
        protected Vector3 _lookAtPosition;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the camera's target.
        /// </summary>
        public Transform Target
        {
            get { return _target; }
            set { _target = value; }
        }

        /// <summary>
        /// Gets or sets camera's eye position
        /// </summary>
        public Vector3 LookAt
        {
            get { return _lookAtPosition; }
            set { _lookAtPosition = value; }
        }

        #endregion

        public Camera(GameObject gameObject)
            : base(gameObject)
        {
            _needProjectUpdate = true;

            // References
            _target = null;
            _reference = Vector3.Zero;
            _upVector = Vector3.Up;

            // Screen view
            _aspectRatio = (float)((float)YnScreen.Width / (float)YnScreen.Height);
            _fieldOfView = MathHelper.PiOver4;
            _nearPlane = 1.0f;
            _farPlane = 3500.0f;

            // Basic matrix init
            _projection = Matrix.Identity;
            _view = Matrix.Identity;
        }

        public virtual void Setup(Vector3 position, Transform target = null, float nearPlane = 10.0f, float farPlane = 2500.0f)
        {
            _target = target;

            GameObject.Transform.Position = position;
            GameObject.Transform.Rotation = Vector3.Zero;

            _lookAtPosition = Vector3.Zero;
            _reference = new Vector3(0.0f, 0.0f, 10.0f);
            _nearPlane = nearPlane;
            _farPlane = farPlane;

            _view = Matrix.CreateLookAt(GameObject.Transform.Position, _lookAtPosition, _upVector);

            ComputeProjectionMatrix();
        }

        public override void Initialize()
        {
            Setup(Vector3.Zero);
        }

        /// <summary>
        /// Compute the projection matrix according to the projection type.
        /// </summary>
        public void ComputeProjectionMatrix()
        {
            if (_projectionType == CameraProjectionType.Perspective)
                _projection = Matrix.CreateOrthographic(YnScreen.Width, YnScreen.Height, _nearPlane, _farPlane);
            else
                _projection = Matrix.CreatePerspectiveFieldOfView(_fieldOfView, _aspectRatio, _nearPlane, _farPlane);
        }

        /// <summary>
        /// Update camera's position and rotation.
        /// </summary>
        public override void Update()
        {
            Matrix matRotation = Matrix.CreateFromYawPitchRoll(GameObject.Transform.Rotation.Y, GameObject.Transform.Rotation.X, GameObject.Transform.Rotation.Z);

            if (_target != null)
                matRotation *= Matrix.CreateRotationY(_target.Rotation.Y);

            Vector3 position = Vector3.Transform(_reference, matRotation);

            if (_target != null)
                position += _target.Position;

            _view = Matrix.CreateLookAt(position, _lookAtPosition, _upVector);

            if (_needProjectUpdate)
                _projection = Matrix.CreatePerspectiveFieldOfView(_fieldOfView, _aspectRatio, _nearPlane, _farPlane);
        }
    }
}
