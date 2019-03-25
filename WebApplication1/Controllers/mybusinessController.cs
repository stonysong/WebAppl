using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class mybusinessController : ApiController
    {
        [HttpGet]

        public BaseResults getmybus()
        {

            throw new Exception("sdflkjvlsadkfuygoiaeuhbvsak;ldjvhl;sad");
            SysObjectExtentions.Warn("20199", "测试！");
            return new BaseResults() { success = true, messagetony = "message" };
        }

       
    }
}
