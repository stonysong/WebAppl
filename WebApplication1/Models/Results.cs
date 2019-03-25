using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    /// <summary>
    /// 返回结果统一实体类
    /// </summary>
    public class Results
    {
        /// <summary>
        /// 是否执行成功
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 返回提示信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回错误码
        /// </summary>
        public string ErrorCode { get; set; }
    }
}