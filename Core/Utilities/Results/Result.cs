using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool IsSuccessful { get; }
        public string Message { get; }

        public Result(bool isSuccessful)
        {
            this.IsSuccessful = isSuccessful;
        }

        public Result(bool isSuccessful, string message): this(isSuccessful)
        {
            this.Message = message;
        }
    }
}
