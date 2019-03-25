using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models

{
    public class CommonResult: BaseResult
    {
        public virtual object data { get; set; }
    }
}