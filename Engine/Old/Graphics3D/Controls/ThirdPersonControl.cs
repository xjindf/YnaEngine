// YnaEngine - Copyright (C) YnaEngine team
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Yna.Engine.Graphics3D.Camera;
using Yna.Engine.Input;

namespace Yna.Engine.Graphics3D.Controls
{
    /// <summary>
    /// Define a Third Person Controller who will move an object
    /// </summary>
    public class ThirdPersonControl : BaseControl
    {
        /// <summary>
        /// Create a Third Person Controller with a camera. The camera must be have registered a followed object
        /// </summary>
        /// <param name="camera">Camera to use</param>
        public ThirdPersonControl(ThirdPersonCamera camera)
            : base(camera)
        {

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            ApplyPhysics(gameTime);
            Camera.Update(gameTime);
        }

        public override void ApplyPhysics(GameTime gameTime)
        {
            var camera = Camera as ThirdPersonCamera;
            camera.FollowedObject.Translate(PhysicsPosition.Velocity.X * _xDirection, PhysicsPosition.Velocity.Y * _yDirection, PhysicsPosition.Velocity.Z * _zDirection);
            camera.FollowedObject.RotateY(PhysicsRotation.Velocity.Y * _yRotation);
        }

        protected override void UpdateKeyboardInput(GameTime gameTime)
        {
            // Translation Up/Down
            if (YnInput.Keys.Pressed(Keys.A))
                PhysicsPosition.Velocity.Y += _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            else if (YnInput.Keys.Pressed(Keys.E))
                PhysicsPosition.Velocity.Y -= _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;

            // Translation Forward/backward
            if (YnInput.Keys.Pressed(Keys.Z) || YnInput.Keys.Up)
                PhysicsPosition.Velocity.Z += _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            else if (YnInput.Keys.Pressed(Keys.S) || YnInput.Keys.Down)
                PhysicsPosition.Velocity.Z -= _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;

            // Translation Left/Right
            if (YnInput.Keys.Pressed(Keys.Q))
                PhysicsPosition.Velocity.X += _strafeSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            else if (YnInput.Keys.Pressed(Keys.D))
                PhysicsPosition.Velocity.X -= _strafeSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;

            // Rotation Left/Right
            if (YnInput.Keys.Left)
                PhysicsRotation.Velocity.Y += _rotationSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            else if (YnInput.Keys.Right)
                PhysicsRotation.Velocity.Y -= _rotationSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;

            // Rotate the camera arround the followed object
            if (YnInput.Keys.Pressed(Keys.W))
                Camera.RotateY(-_rotationSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.1f);
            else if (YnInput.Keys.Pressed(Keys.X))
                Camera.RotateY(_rotationSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.1f);
        }

        protected override void UpdateGamepadInput(GameTime gameTime)
        {
            Vector2 leftStickValue = YnInput.Gamepad.LeftStickValue(_playerIndex);
            Vector2 rightStickValue = YnInput.Gamepad.RightStickValue(_playerIndex);

            PhysicsPosition.Velocity.X += leftStickValue.X * _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            PhysicsPosition.Velocity.Z += -leftStickValue.Y * _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            PhysicsRotation.Velocity.Y += -rightStickValue.X * _rotationSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;

            if (YnInput.Gamepad.LeftTrigger(PlayerIndex.One))
                PhysicsPosition.Velocity.Y += _moveSpeed * YnInput.Gamepad.LeftTriggerValue(PlayerIndex.One) * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            else if (YnInput.Gamepad.RightTrigger(PlayerIndex.One))
                PhysicsPosition.Velocity.Y += -_moveSpeed * YnInput.Gamepad.RightTriggerValue(PlayerIndex.One) * gameTime.ElapsedGameTime.Milliseconds * 0.01f;

            Camera.RotateX(-rightStickValue.Y * _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.1f);


            if (YnInput.Gamepad.LeftShoulder(PlayerIndex.One))
                Camera.RotateY(-_moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.1f);
            else if (YnInput.Gamepad.RightShoulder(PlayerIndex.One))
                Camera.RotateY(_moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.1f);

            //Camera.RotateY(-rightStickValue.X * _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.1f);
        }

        protected override void UpdateMouseInput(GameTime gameTime)
        {
            var camera = Camera as ThirdPersonCamera;

            if (YnInput.Mouse.Click(MouseButton.Left) || YnInput.Mouse.Click(MouseButton.Right))
            {
                if (YnInput.Mouse.Click(MouseButton.Left))
                    PhysicsPosition.Velocity.Z += YnInput.Mouse.Delta.Y * 0.5f * _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;

                PhysicsRotation.Velocity.Y = -YnInput.Mouse.Delta.X * 0.5f * _rotationSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            }

            if (YnInput.Mouse.Click(MouseButton.Right))
            {
                Camera.RotateX(Camera.Pitch + YnInput.Mouse.Delta.Y);
                Camera.RotateY(Camera.Roll - YnInput.Mouse.Delta.X);
            }

            else if (YnInput.Mouse.Click(MouseButton.Middle))
            {
                camera.Distance += YnInput.Mouse.Delta.X;
                camera.Angle += YnInput.Mouse.Delta.Y;
            }
        }
    }
}
