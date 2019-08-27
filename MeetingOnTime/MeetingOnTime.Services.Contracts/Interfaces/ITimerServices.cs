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
        Task<string> StartTimer(string timerId);
        Task<string> StopTimer(string timerId);

        Task<string> ResetTimer(string timerId);
        Task<string> SetTimer(DateTime endTime);

        event EventHandler TimerStarted;
        event EventHandler TimerStopped;
        event EventHandler TimerReset;

    }
}
