using MeetingOnTime.Services.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MeetingOnTime.Services.Contracts.Interfaces
{
    public interface ITimerService
    {
        Task<Result<string>> CreateNewTimer();
        Task<Result<TimeSpan>> GetElapsedTimeSpan(string timerId);
        Task<Result<long>> GetElapsedSeconds(string timerId);
        Task<Result<string>> GetElapsedString(string timerId);
        Task<Result<string>> GetElapsedString(string timerId, string format);
        Task<Result<string>> StartTimer(string timerId);
        Task<Result<string>> StopTimer(string timerId);

        Task<Result<string>> ResetTimer(string timerId);
        Task<Result<string>> SetTargetTimeSpan(TimeSpan endTime);
        Task<Result<string>> SetTargetSeconds(long endTime);
        Task<Result<string>> SetTargetString(string minutes, string seconds);

        /*
        event EventHandler TimerStarted;
        event EventHandler TimerStopped;
        event EventHandler TimerReset;
        */

    }
}
