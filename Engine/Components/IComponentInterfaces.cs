using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Components
{
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
}
