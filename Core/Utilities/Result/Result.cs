using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public abstract class Result : IResult
    {
        public bool IsSucces { get; set; }
        public string Message { get; set; }

        public Result(bool isSucces)
        {
            this.IsSucces = isSucces;
        }

        public Result(bool isSucces,string message) : this(isSucces)
        {
            this.Message = message;
        }
    }
}
