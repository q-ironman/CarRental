using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public abstract class DataResult<T> : IDataResult<T>
    {
        public bool IsSucces { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public DataResult(bool isSucces, T data)
        {
            this.IsSucces = isSucces;
            this.Data = data;
        }

        public DataResult(bool isSucces, T data, string message) : this(isSucces,data)
        {
            this.Message = message;
        }
    }
}
