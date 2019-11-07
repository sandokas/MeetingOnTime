using MeetingOnTime.Services.Contracts.DTOs;
using MeetingOnTime.Services.Contracts.Interfaces;
using System;
using System.Threading.Tasks;

namespace MeetingOnTime.Services
{

    public class TimerService : ITimerService
    {
        private MeetingTimer timer;
        private void Dummy()
        {
            ;
        }
        public async Task<Result<string>> CreateNewTimer()
        {

            timer = new MeetingTimer();



            var result = new Result<string>();
            result.value = timer.TimerId;
            result.isSucessfull = true;

            //Persist Dummy
            await Task.Run(Dummy);

            return result;
        }

        public Task<Result<long>> GetElapsedSeconds(string timerId)
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
