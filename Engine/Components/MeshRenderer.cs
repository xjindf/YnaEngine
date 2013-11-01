using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine.Components
{
    public class MeshRenderer : DrawableComponent, IRenderer
    {
        public MeshRenderer(GameObject gameObject)
            : base(gameObject)
        {

        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
