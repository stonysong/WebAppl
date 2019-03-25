using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public interface IBaseResult
    {
        bool success { get; set; }
        string errcode { get; set; }
        string errmsg { get; set; }
        string errdesc { get; set; }
        long records { get; set; }
    }
}