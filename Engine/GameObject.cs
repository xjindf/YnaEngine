﻿// YnaEngine - Copyright (C) YnaEngine team
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.
using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Yna.Engine
{
    public enum SceneLayer
    {
        Layer2D, Layer3D, GUI
    }

    /// <summary>
    /// Base class for all object on the Framework. A basic object is updateable
    /// </summary>
    public abstract class GameObject
    {
        #region private declarations

        private static uint counterId = 0x0001;

        protected uint _id;
        protected string _name;
        protected string _tag;
        protected SceneLayer _sceneLayer;
        protected bool _enabled;
        protected List<GameObject> _children;

        #endregion

        #region Properties

        /// <summary>
        /// Get the unique identification code of this object
        /// </summary>
        public uint Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Gets or Sets the name of this object
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets or sets the tag
        /// </summary>
        public string Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        public SceneLayer Layer
        {
            get { return _sceneLayer;  }
            set { _sceneLayer = value; }
        }

        /// <summary>
        /// Active or Desactive this object
        /// </summary>
        public bool Active
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        /// <summary>
        /// Pause or resume updates
        /// </summary>
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        public List<GameObject> Children
        {
            get { return _children; }
            set { _children = value; }
        }

        #endregion

        public GameObject()
        {
            _id = counterId++;
            _name = String.Format("GameObject{0}", Id.ToString());
            _tag = "Default";
            _children = new List<GameObject>();
            _sceneLayer = SceneLayer.Layer2D;
            _enabled = true;
        }

        /// <summary>
        /// Update method called on each engine update
        /// </summary>
        /// <param name="gameTime"></param>
        public abstract void Update(GameTime gameTime);
    }
}
