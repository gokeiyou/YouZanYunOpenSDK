using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace System
{
    public static class CustomExtend
    {
        /// <summary>
        /// 读取属性特性名称
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static string GetApiField(this MemberInfo member)
        {
            var attr = member.GetCustomAttribute<ApiFieldAttribute>();
            if (attr == null) return member.Name;
            return attr.Name;
        }
    }
}
