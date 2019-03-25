using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Exceptions
{
    public class DebugException:Exception
    {

        private EBaseModel emd = new EBaseModel();
        public DebugException(string code,string msg) {

            emd.Message = msg;
            emd.ErrorCode = code;
        }
        public override string Message
        {
            get
            {
                return emd.toJson();
            }

        }
    }
}