using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Results.Abstract
{
    public interface IDataResult<out T> : IResult
    {
        public T Data { get;}
    }
}
