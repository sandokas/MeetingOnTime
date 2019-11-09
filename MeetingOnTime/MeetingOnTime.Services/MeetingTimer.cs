using System;
using System.Collections.Generic;
using System.Text;

namespace MeetingOnTime.Services
{
    public class MeetingTimer
    {
        private readonly string _timerId;
        private TimeSpan _originalTimeSpan;
        private DateTimeOffset _runningEndTime;
        private TimeSpan _currentlyStoppedTimeSpan;
        private bool _isStarted;
        public string TimerId {
            get => _timerId;
        }
        public MeetingTimer(TimeSpan targetTimeSpan)
        {
            _timerId = Guid.NewGuid().ToString();
            _currentlyStoppedTimeSpan = targetTimeSpan;
            _originalTimeSpan = targetTimeSpan;
        }
        public void SetTargetTimeSpan(TimeSpan targetTimeSpan)
        {
            if (_isStarted)
            {
                _runningEndTime = DateTimeOffset.UtcNow + targetTimeSpan;
            }
            else
            {
                _currentlyStoppedTimeSpan = targetTimeSpan;
            }
        }
        public void Start()
        {
            _isStarted = true;
            _runningEndTime = DateTimeOffset.UtcNow + _currentlyStoppedTimeSpan;
        }
        public void Stop()
        {
            _isStarted = false;
            _currentlyStoppedTimeSpan = _runningEndTime - DateTimeOffset.UtcNow;
        }
        public TimeSpan GetTimeSpan ()
        {
            if (_isStarted)
            {
                return _runningEndTime - DateTimeOffset.UtcNow;
            }
            else
            {
                return _currentlyStoppedTimeSpan;
            }
        }
        public bool isRunning { get => _isStarted; }

    }
}
