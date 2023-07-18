using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buou07_StopWatch
{

    class StopWatch
    {
        private DateTime startTime, endTime;

        public StopWatch(DateTime startTime, DateTime endTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }
        public StopWatch()
        {
            startTime = DateTime.Now;
        }

        public DateTime StartTime { get => startTime; }
        public DateTime EndTime { get => endTime; }

        public void Start() { startTime = DateTime.Now; }
        public void Stop() { endTime = DateTime.Now; }

        public double GetElapsedTime()
        {
            return (endTime - startTime).TotalMilliseconds;
        }


    }
}    

