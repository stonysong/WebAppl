using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Filters;
using WebApplication1.Models;
using WebApplication1.Models.Exceptions;

namespace WebApplication1.App_Start
{
    public class ApiResultAttribute : System.Web.Http.Filters.ActionFilterAttribute
    {


        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
            CommonResult result = new CommonResult();

            if (actionExecutedContext.Response == null)
            {
                result.success = false;

                result.errcode = "2019";
                result.errdesc = actionExecutedContext.Exception.Message;
                if (actionExecutedContext.Exception.Message != null)
                {

                    try
                    {
                        var md = actionExecutedContext.Exception.Message.JsonToObject<EBaseModel>();
                        result.errcode = md.ErrorCode;
                        result.errdesc = md.Message;
                        result.errmsg = md.Message;

                    }
                    catch
                    {
                        result.errdesc = actionExecutedContext.Exception.Message;
                        result.errmsg = actionExecutedContext.Exception.Message;


                    }
                }


                result.errmsg = actionExecutedContext.Exception.Source;

                HttpResponseMessage resultss = new HttpResponseMessage { Content = new StringContent(result.toJson(), Encoding.GetEncoding("UTF-8"), "application/json") };
                //结果转为自定义消息格式
                HttpResponseMessage httpResponseMessages = resultss;
                // 重新封装回传格式
                actionExecutedContext.Response = httpResponseMessages;
            }
            else
            {
                // 取得由 API 返回的状态代码
                if (actionExecutedContext.ActionContext.Response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    result.errcode = actionExecutedContext.ActionContext.Response.StatusCode.ToString();
                    if (actionExecutedContext.ActionContext.Response.Content != null) result.errdesc = "请求错误代码：" + actionExecutedContext.ActionContext.Response.Content.ToString();
                }


                try
                {

                    //var brm = actionExecutedContext.ActionContext.Response.Content.ReadAsAsync<BaseResult>();
                    // 取得由 API 返回的资料
                    var str = actionExecutedContext.ActionContext.Response.Content.ReadAsAsync<object>().Result;

                    if (str is BaseResult)//判断是否继承了基类，继承了基类后，不做任何处理
                    {

                        // BaseResult ibr = (BaseResult)str;//判断是否继承了基类

                        HttpResponseMessage resultss = new HttpResponseMessage { Content = new StringContent(str.toJson(), Encoding.GetEncoding("UTF-8"), "application/json") };
                        //结果转为自定义消息格式
                        HttpResponseMessage httpResponseMessages = resultss;
                        // 重新封装回传格式
                        actionExecutedContext.Response = httpResponseMessages;
                        return;
                    }
                    else
                    {   //没有继承基类，进行封装
                        result.data = str;
                    }

                }
                catch
                {
                    result.errcode = "100000";
                    result.errdesc = "异常错误联系开发人员！";


                }
                HttpResponseMessage results = new HttpResponseMessage { Content = new StringContent(result.toJson(), Encoding.GetEncoding("UTF-8"), "application/json") };
                //结果转为自定义消息格式
                HttpResponseMessage httpResponseMessage = results;
                // 重新封装回传格式
                actionExecutedContext.Response = httpResponseMessage;
            }
        }

    }
}