using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.App_Start;

namespace WebApplication1.Models
{
    public class BaseResults:BaseResult
    {
        public  string messagetony { get; set; }

        public string OKMessage { get; set; }
    }
}