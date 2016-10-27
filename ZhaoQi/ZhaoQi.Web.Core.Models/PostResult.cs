using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZhaoQi.Web.Core.Models
{
    public class PostResult<T>
    {
        public bool IsSuccess { get; set; }
        public T ResultObject { get; set; }
        public string ErrorMessage { get; set; }
    }
}
