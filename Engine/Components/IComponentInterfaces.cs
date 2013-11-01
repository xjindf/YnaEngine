using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Components
{
    public enum ColliderType
    {
        Two2D, Three3D
    }

    public interface IComponent
    {
        void Initialize();

        void Update();
    }

    public interface IDrawableComponent
    {
        void LoadContent();
        
        void UnloadContent();

        void Draw();
    }

    public interface ICollider
    {
        ColliderType ColliderType { get; }

        void DetectCollisions();
    }

    public interface IRenderer
    {
        void Draw();
    }
}
