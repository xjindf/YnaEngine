using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yna.Engine.Components.Animation;

namespace Yna.Engine.Components
{
    public class SpriteRenderer : DrawableComponent
    {
        // Moving the sprite
        protected Vector2 _position;
        protected Vector2 _distance;
        protected Vector2 _direction;
        protected Vector2 _lastPosition;
        protected Vector2 _lastDistance;

        // Position
        protected Point _size;
        protected Rectangle? _sourceRectangle;
        protected Rectangle _gameViewport;

        // Texture
        protected Texture2D _texture;
        protected string _assetName;
        protected bool _assetLoaded;

        // Draw params
        protected Color _color;
        protected float _rotation;
        protected Vector2 _origin;
        protected Vector2 _scale;
        protected SpriteEffects _effects;
        protected float _layerDepth;
        protected float _alpha;

        // Animations
        protected bool _hasAnimation;
        protected SpriteAnimator _animator;

        public Point Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public SpriteRenderer()
        {
            _size = Point.Zero;
            _texture = null;
            _assetName = String.Empty;
            _assetLoaded = false;
            _color = Color.White;
            _rotation = 0.0f;
            _origin = Vector2.Zero;
            _scale = Vector2.One;
            _alpha = 1.0f;
            _effects = SpriteEffects.None;
            _layerDepth = 1.0f;

            _sourceRectangle = null;
            _gameViewport = new Rectangle(0, 0, YnScreen.Width, YnScreen.Height);

            _hasAnimation = false;
            _animator = new SpriteAnimator();

            _position = Vector2.Zero;
            _lastPosition = Vector2.Zero;
            _distance = Vector2.One;
            _lastDistance = Vector2.Zero;
            _direction = Vector2.Zero;
        }

        #region Animation methods

        /// <summary>
        /// Prepare the sprite for animation.
        /// </summary>
        /// <param name="width">width of a sprite on the spritesheet</param>
        /// <param name="height">height of a sprite on the spritesheet</param>
        public void PrepareAnimation(int width, int height)
        {
            _animator.Initialize(width, height, _texture.Width, _texture.Height);

            // The sprite size is now the size of a sprite on the spritesheet
            _size.X = width;
            _size.Y = height;
            
            _hasAnimation = true;
        }

        /// <summary>
        /// Add an animation
        /// </summary>
        /// <param name="name">Animation name</param>
        /// <param name="indexes">Array of index that represent images</param>
        /// <param name="frameRate">Framerate for this animation</param>
        /// <param name="reversed">Reverse or not the animation</param>
        public void AddAnimation(string name, int[] indexes, int frameRate, bool reversed)
        {
            _animator.Add(name, indexes, frameRate, reversed);
            _sourceRectangle = _animator.Animations[name].Rectangle[0];
        }

        /// <summary>
        /// Add an animation
        /// </summary>
        /// <param name="name">Animation name</param>
        /// <param name="startIndex">The start sprite index (included)</param>
        /// <param name="endIndex">The end sprite index (included)</param>
        /// <param name="frameRate">Framerate for this animation</param>
        /// <param name="reversed">Reverse or not the animation</param>
        public void AddAnimation(string name, int startIndex, int endIndex, int frameRate, bool reversed)
        {
            // Securize the start and end index
            if (startIndex > endIndex)
            {
                int temp = endIndex;
                endIndex = startIndex;
                startIndex = temp;
            }

            // Build the index array
            int count = endIndex - startIndex;
            int[] indexes = new int[count + 1];
            int currentIntex = startIndex;

            for (int i = 0; i <= count; i++)
            {
                indexes[i] = currentIntex;
                currentIntex++;
            }

            // Call the proper method
            AddAnimation(name, indexes, frameRate, reversed);
        }

        /// <summary>
        /// Add an animation
        /// </summary>
        /// <param name="name">Animation name</param>
        /// <param name="rectangles">Array of Rectangles that represents animations on the spritesheet</param>
        /// <param name="frameRate">Framerate for this animation</param>
        /// <param name="reversed">Reverse or not the animation</param>
        public void AddAnimation(string name, Rectangle[] rectangles, int frameRate, bool reversed)
        {
            _animator.Add(name, rectangles, frameRate, reversed);
            _sourceRectangle = _animator.Animations[name].Rectangle[0];
        }

        /// <summary>
        /// Get the current animation index
        /// </summary>
        /// <param name="animationKeyName">Animation name</param>
        /// <returns>Index of the animation</returns>
        public int GetCurrentAnimationIndex(string animationKeyName)
        {
            if (_hasAnimation)
                return _animator.Animations[animationKeyName].Index;
            else
                return 0;
        }

        /// <summary>
        /// Get the length of an animation
        /// </summary>
        /// <param name="animationKeyName">Animation name</param>
        /// <returns>Length of the animation</returns>
        public int GetAnimationLenght(string animationKeyName)
        {
            if (_hasAnimation)
                return _animator.Animations[animationKeyName].Count;
            else
                return 0;
        }

        /// <summary>
        /// Get the SpriteAnimation object for a specified animation
        /// </summary>
        /// <param name="animationKeyName">Animation name</param>
        /// <returns>The SpriteAnimation object</returns>
        public SpriteAnimation GetAnimation(string animationKeyName)
        {
            if (_hasAnimation)
                return _animator.Animations[animationKeyName];
            else
                return null;
        }

        /// <summary>
        /// Play an animation
        /// </summary>
        /// <param name="animationName">Animation name</param>
        public void Play(string animationName)
        {
            _sourceRectangle = _animator.Play(animationName, ref _effects);
        }

        #endregion

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void AfterUpdate()
        {
            _position.X = GameObject.Transform.Position.X;
            _position.Y = GameObject.Transform.Position.Y;
        }

        public override void Draw()
        {
            if (Enabled)
                spriteBatch.Draw(_texture, _position, _sourceRectangle, _color * _alpha, _rotation, _origin, _scale, _effects, _layerDepth);
        }
    }
}
