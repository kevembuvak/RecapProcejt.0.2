using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<Type> : Result, IDataResult<Type>
    {
        public Type Data { get; }

        public DataResult(Type data, bool isSuccessful, string message): base(isSuccessful, message)
        {
            this.Data = data;
        }
        public DataResult(Type data, bool isSuccessful) : base(isSuccessful)
        {
            this.Data = data;
        }
    }
}
