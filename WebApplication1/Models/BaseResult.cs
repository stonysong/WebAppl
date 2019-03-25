using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BaseResult
    {
        public virtual bool success { get; set; }
        public virtual string errcode { get; set; }
        public virtual string errmsg { get; set; }
        public virtual string errdesc { get; set; }
        public virtual long records { get; set; }
    }
}