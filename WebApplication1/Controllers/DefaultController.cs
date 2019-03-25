using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.App_Start;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        public BaseResult getBaseResults()
        {
            return new BaseResults() { success = true, messagetony = "tony" };
        }
        [HttpGet]
        public Results getresults()
        {
            return new Results() { IsSuccess = false };
        }
    }
}
