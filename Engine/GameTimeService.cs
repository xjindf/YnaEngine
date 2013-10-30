using Microsoft.Xna.Framework;
using System;
using System.Diagnostics;

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

        public GameTimeService()
        {
            _lastUpdate = new TimeSpan(DateTime.Now.Ticks);
            _stopWatch = new Stopwatch();
            _stopWatch.Start();
            _gameTime = new GameTime();
            _tmpElapsed = new TimeSpan();
            _tmpTotal = new TimeSpan();

            YnTime.Service = this;
        }

        public void Initialize()
        {
            _stopWatch.Reset();
            _stopWatch.Start();
            YnTime.Reset();
        }

        public void Update()
        {
            if (Enabled)
            {
                _tmpTotal = _stopWatch.Elapsed;
                _tmpElapsed = _tmpElapsed - _lastUpdate;
                _gameTime.ElapsedGameTime = _tmpElapsed;
                _gameTime.TotalGameTime = _tmpTotal;
            }
        } 
    }
}
