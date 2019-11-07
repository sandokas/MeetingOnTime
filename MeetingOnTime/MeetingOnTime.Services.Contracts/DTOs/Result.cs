using System;
using System.Collections.Generic;
using System.Text;

namespace MeetingOnTime.Services.Contracts.DTOs
{
    public class Result<T>
    {
        public bool isSucessfull;
        public T value;
    }
}
