using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yna.Engine;
using Yna.Engine.Components;
using Yna.Engine.Scene;

namespace TestProject
{
    public class TestGame : YnGame
    {
        public TestGame()
            : base (1024, 600, "YnaEngine 2.0 Test application")
        {

        }

        protected override void Initialize()
        {
            YnG.SceneManager.Add(new TestScene());

            YnG.SceneManager.LoadScene(0);
            base.Initialize();
        }
    }

    class TestScene : Scene
    {
        GameObject sprite;

        public TestScene ()
            : base ()
        {

        }

        public override void Initialize()
        {
            base.Initialize();

            SpriteRenderer spriteRend = new SpriteRenderer();
            spriteRend.LoadTexture("sprite");

            sprite = new GameObject();
            sprite.AddComponent(spriteRend);
            Add(sprite);

            spriteRend.PrepareAnimation(64, 64);

            // Add 4 animations
            // 1 - Name for the animation
            // 2 - An array of index that represent what image we want using
            // 3 - The framerate for the animation
            // 4 - We don't reverse the image because we have all animation in the spritesheet
            spriteRend.AddAnimation("up", 0, 8, 25, false);
            spriteRend.AddAnimation("left", 9, 17, 25, false);
            spriteRend.AddAnimation("down", 18, 26, 25, false);
            spriteRend.AddAnimation("right", 27, 35, 25, false);
        }
    }
}
