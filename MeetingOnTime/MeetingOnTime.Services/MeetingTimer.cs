using System;
using System.Collections.Generic;
using System.Text;

namespace MeetingOnTime.Services
{
    public class MeetingTimer
    {
        private readonly string _timerId;
        public string TimerId {
            get => _timerId;
        }
        public MeetingTimer()
        {
            _timerId = Guid.NewGuid().ToString();
        }
        public TimeSpan TargetTimeSpan { get; set; }
        public TimeSpan CurrentTimeSpan { get; set; }
        public bool IsRunning { get; set; }
    }
}
