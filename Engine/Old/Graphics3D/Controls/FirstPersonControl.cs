﻿// YnaEngine - Copyright (C) YnaEngine team
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Yna.Engine.Graphics3D.Camera;

namespace Yna.Engine.Graphics3D.Controls
{
    /// <summary>
    /// A first person controller who can be used with keyboard, mouse and gamepad
    /// </summary>
    public class FirstPersonControl : BaseControl
    {
        
        /// <summary>
        /// Create a new FPS Controller for the first player
        /// </summary>
        /// <param name="camera">The FirstPersonCamera to use with this controller</param>
        public FirstPersonControl(FirstPersonCamera camera)
            : this(camera, PlayerIndex.One)
        {
  
        }

        /// <summary>
        /// Create a new FPS controller for the specified player
        /// </summary>
        /// <param name="camera">The FirstPersonCamera to use with this controller</param>
        public FirstPersonControl(FirstPersonCamera camera, PlayerIndex index)
            : base(camera, index)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            ApplyPhysics(gameTime);

            Camera.Update(gameTime);
        }

        protected override void UpdateKeyboardInput(GameTime gameTime)
        {
            // Translation Up/Down
            if (YnInput.Keys.Pressed(Keys.A))
                PhysicsPosition.Velocity.Y += _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            else if (YnInput.Keys.Pressed(Keys.E))
                PhysicsPosition.Velocity.Y -= _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;

            // Translation Forward/backward
            if (YnInput.Keys.Up)
                PhysicsPosition.Velocity.Z += _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            else if (YnInput.Keys.Down)
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

            // Look Up/Down
            if (YnInput.Keys.Pressed(Keys.PageUp))
                PhysicsRotation.Velocity.X += _pitchSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            else if (YnInput.Keys.Pressed(Keys.PageDown))
                PhysicsRotation.Velocity.X -= _pitchSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;

            // Roll
            if (YnInput.Keys.Pressed(Keys.W))
                PhysicsRotation.Velocity.Z += _pitchSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            else if (YnInput.Keys.Pressed(Keys.X))
                PhysicsRotation.Velocity.Z -= _pitchSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
        }

        protected override void UpdateGamepadInput(GameTime gameTime)
        {
            Vector2 leftStickValue = YnInput.Gamepad.LeftStickValue(_playerIndex);
            Vector2 rightStickValue = YnInput.Gamepad.RightStickValue(_playerIndex);

            // Translate
            PhysicsPosition.Velocity.X += -leftStickValue.X * _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            PhysicsPosition.Velocity.Z += leftStickValue.Y * _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;

            // Rotate
            PhysicsRotation.Velocity.Y += -rightStickValue.X * _rotationSpeed  * gameTime.ElapsedGameTime.Milliseconds * 0.01f; 

            // Pitch
            PhysicsRotation.Velocity.X += -rightStickValue.Y * _pitchSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f; 

            // Move Up
            if (YnInput.Gamepad.LeftShoulder(_playerIndex))
                PhysicsPosition.Velocity.Y += _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            else if (YnInput.Gamepad.RightShoulder(_playerIndex))
                PhysicsPosition.Velocity.Y -= _moveSpeed * gameTime.ElapsedGameTime.Milliseconds * 0.01f;
        }

        protected override void UpdateMouseInput(GameTime gameTime)
        {
            Camera.RotateY(YnInput.Mouse.Delta.X * 0.2f);
            Camera.RotateX(-YnInput.Mouse.Delta.Y * 0.2f);
        }
    }
}
