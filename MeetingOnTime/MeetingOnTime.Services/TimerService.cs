using MeetingOnTime.Services.Contracts.DTOs;
using MeetingOnTime.Services.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetingOnTime.Services
{

    public class TimerService : ITimerService
    {
        private IList<MeetingTimer> timers;
        public TimerService()
        {
            timers = new List<MeetingTimer>();
        }

        public async Task<Result<string>> CreateNewTimer(TimeSpan endTime)
        {
            var timer = new MeetingTimer(endTime);

            // receive a persistence service and persist
            timers.Add(timer);

            var result = new Result<string>();
            result.value = timer.TimerId;
            result.isSucessfull = true;

            return result;
        }

        public async Task<Result<string>> CreateNewTimerSeconds(long endTime)
        {
            if (endTime < 0 || endTime > 9000000000)
                throw new Exception($"EndTime must be between 0 and 9000000000");

            var nanoEndTime = 1000000000 * endTime;
            TimeSpan timeSpan = new TimeSpan(nanoEndTime);
            return await CreateNewTimer(timeSpan).ConfigureAwait(false);
        }

        public async Task<Result<string>> CreateNewTimerString(string minutesStr, string secondsStr)
        {
            int hours = 0;
            int minutes;
            int seconds;

            if (String.IsNullOrWhiteSpace(minutesStr) || !int.TryParse(minutesStr,out minutes)) { throw new Exception($"Minutes {minutesStr} are not valid."); }
            if (String.IsNullOrWhiteSpace(minutesStr) || !int.TryParse(secondsStr, out seconds)) { throw new Exception($"Seconds {secondsStr} are not valid."); }

            TimeSpan timeSpan = new TimeSpan(hours, minutes, seconds);
            return await CreateNewTimer(timeSpan).ConfigureAwait(false);
        }

        public async Task<Result<long>> GetElapsedSeconds(string timerId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> GetElapsedString(string timerId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> GetElapsedString(string timerId, string format)
        {
            throw new NotImplementedException();
        }

        public Task<Result<TimeSpan>> GetElapsedTimeSpan(string timerId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> ResetTimer(string timerId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> SetTargetSeconds(long endTime)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> SetTargetString(string minutes, string seconds)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> SetTargetTimeSpan(TimeSpan endTime)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> StartTimer(string timerId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string>> StopTimer(string timerId)
        {
            throw new NotImplementedException();
        }
    }
}
