using System;
using System.Collections.Generic;
using System.Text;

namespace YouZan.Open.Common.Extensions.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ApiFieldAttribute : Attribute
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        public ApiFieldAttribute()
            : this(null)
        {

        }
        public ApiFieldAttribute(string name)
        {
            this.Name = name;
        }
    }
}
