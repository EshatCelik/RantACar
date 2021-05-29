using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)//message ve succes aynı anda kullanılsın diye this yazılıyor
        {
            Message = message;

        }
        public Result(bool success)
        {
            Success = success;

        }
        public bool Success { get; }

        public string Message { get; }
    }
}
