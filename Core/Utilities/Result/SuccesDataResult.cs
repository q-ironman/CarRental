using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class SuccesDataResult<T> : DataResult<T>,IDataResult<T>
    {
        public SuccesDataResult(T data) : base(true, data)
        {
        }

        public SuccesDataResult(T data, string message) : base(true, data, message)
        {
        }
    }
}
