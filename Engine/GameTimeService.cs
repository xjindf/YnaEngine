using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Yna.Engine
{
    public class GameTimeService
    {
        public bool Enabled { get; set; }

        private GameTime _gameTime;
        private Stopwatch _stopWatch;
        private TimeSpan _lastUpdate;
        private TimeSpan _tmpTotal;
        private TimeSpan _tmpElapsed;

        public GameTime GameTime
        {
            get { return _gameTime; }
        }

        public void Initialize()
        {
            _lastUpdate = new TimeSpan(DateTime.Now.Ticks);
            _stopWatch = new Stopwatch();
            _stopWatch.Start(); 
        }

        public void Update()
        {
            if (Enabled)
            {
                _tmpElapsed = _stopWatch.Elapsed;
                _tmpElapsed = _tmpElapsed - _lastUpdate;
                _gameTime.ElapsedGameTime = _tmpElapsed;
                _gameTime.TotalGameTime = _tmpElapsed;
            }
        } 
    }
}
