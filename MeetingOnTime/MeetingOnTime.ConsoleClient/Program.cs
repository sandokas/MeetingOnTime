using MeetingOnTime.Services;
using MeetingOnTime.Services.Contracts.DTOs;
using MeetingOnTime.Services.Contracts.Interfaces;
using System;
using System.Threading.Tasks;

namespace MeetingOnTime.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CallServices().Wait();
        }
        static async Task CallServices()
        {
            TimerService timerService = new TimerService();
            Result<string> result = await timerService.CreateNewTimerSeconds(300).ConfigureAwait(false);

            Console.WriteLine($"Created timer with id:{result.value}");
        }
    }
}
