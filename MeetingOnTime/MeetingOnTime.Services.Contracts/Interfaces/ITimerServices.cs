using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MeetingOnTime.Services.Contracts
{
    public interface ITimerServices
    {
        Task<string> CreateNewTimer();
        Task<DateTime> GetCurrentTime(string timerId);
        Task<long> GetCurrentTimeSeconds(string timerId);
        Task<string> GetCurrentTimeString(string timerId);
        Task<string> StartTimer(string timerId);
        Task<string> StopTimer(string timerId);

        Task<string> ResetTimer(string timerId);
        Task<string> SetTime(DateTime endTime);
        Task<string> SetTimeSeconds(long endTime);
        Task<string> SetTimeString(string endTime);
        Task<string> SetTimeString(string minutes, string seconds);

        event EventHandler TimerStarted;
        event EventHandler TimerStopped;
        event EventHandler TimerReset;

    }
}
