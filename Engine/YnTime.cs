using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine
{
    public class YnTime
    {
        internal static GameTimeService gameTimeService;

        public static float DeltaTime
        {
            get { return gameTimeService.GameTime.ElapsedGameTime.Milliseconds * TimeScale; }
        }

        public static float TimeScale { get; set; }

        internal void Reset()
        {
            gameTimeService.Initialize();
            TimeScale = 1.0f;
        }
    }
}
