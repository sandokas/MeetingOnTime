using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.meetingontime
{
    public class MeetingTimer
    {
        private bool _running = false;
        private DateTime frozenTime = DateTime.MinValue;
        private DateTime targetTime = DateTime.MaxValue;
        
        public MeetingTimer()
        {
            _running = false;
        }

        public MeetingTimer(double milliseconds)
        {
            this.Start(milliseconds);
        }
        public void Stop()
        {
            if (_running) { 
                frozenTime = DateTime.Now;
                _running = false;
            }
            // TODO: else: for distributed systems inform it that it has already stopped and provide the adjusted targetTime/timespan (targetTime - frozenTime).
        }
        public void Start(double milliseconds)
        {
            if (!_running)
            {
                frozenTime = DateTime.Now;
                targetTime = frozenTime.AddMilliseconds(milliseconds);
                _running = true;
            }
            else
            {
                // TODO: else: for distributed systems inform it that it has already stopped and provide the adjusted targetTime/timespan (targetTime - frozenTime).
                throw new Exception("Timer is already running!");
            }
        }
        public void Start()
        {
            //caution: overload - start must always update running and stop must always update running AND frozentime (for when start is acting as resume).
            Start((targetTime - frozenTime).TotalMilliseconds);
        }

        public void Start(TimeSpan timeSpan)
        {
            Start(timeSpan.TotalMilliseconds);
        }
        public DateTime GetTargetTime()
        {
            return targetTime;
        }

        public TimeSpan GetTimeSpan()
        {
            //less reliable for distributed systems use GetTargetTime instead.
            return (targetTime - DateTime.Now);
        }

        public void SetTimeSpan(TimeSpan timespan)
        {
            frozenTime = DateTime.Now;
            targetTime = frozenTime.Add(timespan);
        }

        public bool IsRunning()
        {
            return _running;
        }
        public void AddMilliseconds(double milliseconds)
        {
            targetTime.AddMilliseconds(milliseconds);
        }
        public void RemoveMilliseconds(double milliseconds)
        {
            targetTime.AddMilliseconds(-milliseconds);
        }
    }
}
