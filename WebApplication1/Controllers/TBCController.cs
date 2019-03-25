using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class TBCController : ApiController
    {
        [HttpGet]
        public string teststring()
        {
            
                int m = 0;
               
            
            return "tony";
        }
    }
}