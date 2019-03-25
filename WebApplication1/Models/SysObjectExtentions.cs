using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.Exceptions;

namespace System
{
    public static class SysObjectExtentions
    {

        /// <summary>
        /// Json字符串反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T JsonToObject<T>(this string str) where T : class
        {
            if (str == null) return null;
            if (str.ToString().Trim().Length == 0) return default(T);
            try
            {
                return JsonConvert.DeserializeObject<T>(str);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 对象转换为ＪＳＯＮ
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string toJson(this object obj)
        {
            if (obj == null) return null;

            try
            {
                return JsonConvert.SerializeObject(obj);
            }
            catch
            {
                return null;
            }
        }

        public static  void  Warn(string Code,string Msg)
        {
            throw
                  new DebugException(Code,Msg);
        }
    }
}