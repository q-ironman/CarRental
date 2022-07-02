using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class FailResult : Result,IResult
    {
        public FailResult() : base(false)
        {
        }

        public FailResult(string message) : base(false,message)
        {
        }
    }
}
