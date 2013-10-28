using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yna.Engine
{
    public class YnTime
    {
        internal static GameTimeService Service;

        public static float DeltaTime
        {
            get { return Service.GameTime.ElapsedGameTime.Milliseconds * TimeScale; }
        }

        public static float TimeScale { get; set; }

        internal static void Reset()
        {
            Service.Initialize();
            TimeScale = 1.0f;
        }
    }
}
