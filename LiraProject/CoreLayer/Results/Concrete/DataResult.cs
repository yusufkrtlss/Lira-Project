using CoreLayer.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(ResultStatus resultStatus,T data)
        {
            ResultStatus = resultStatus;
            Data = data;
        }
        public DataResult(ResultStatus resultStatus, string message, T data)
        {
            ResultStatus = resultStatus;
            Message = message;
            Data = data;
        }
        public DataResult(ResultStatus resultStatus, string message, Exception exception,T data)
        {
            ResultStatus = resultStatus;
            Message = message;
            Exception = exception;
            Data = data;
        }
        public T Data { get;}
        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }
    }
}
