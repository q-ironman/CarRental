using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class FailDataResult<T> : DataResult<T>,IDataResult<T>
    {
        public FailDataResult(T data) : base(false, data)
        {
        }

        public FailDataResult(T data, string message) : base(false, data, message)
        {
        }
    }
}
