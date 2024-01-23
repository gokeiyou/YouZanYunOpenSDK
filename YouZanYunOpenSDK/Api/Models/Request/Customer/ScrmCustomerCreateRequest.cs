using System;
using System.Collections.Generic;
using System.Text;
using YouZan.Open.Common.Extensions.Attributes;

namespace YouZan.Open.Api.Entry.Request.Customer
{
    /// <summary>
    /// 创建客户请求参数
    /// </summary>
    public class ScrmCustomerCreateRequest : YouZanRequest
    {

        /// <summary>
        /// 客户信息
        /// </summary>
        [ApiField("customer_create")]
        public CustomerInfo CustomerInfo { get; set; }

        /// <summary>
        /// 客户手机号
        /// </summary>
        [ApiField("mobile")]
        public string Mobile { get; set; }

    }

    /// <summary>
    /// 客户信息类
    /// </summary>
    public class CustomerInfo : YouZanRequest
    {

        /// <summary>
        /// 客户信息备注
        /// </summary>
        [ApiField("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [ApiField("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [ApiField("name")]
        public string Name { get; set; }

        /// <summary>
        /// 客户地址信息
        /// </summary>
        [ApiField("contact_address")]
        public ContactAddress Address { get; set; }

        /// <summary>
        /// 性别
        /// 0：未知
        /// 1：男
        /// 2：女
        /// </summary>
        [ApiField("gender")]
        public int Gender { get; set; }

    }

    /// <summary>
    /// 客户地址信息类
    /// </summary>
    public class ContactAddress : YouZanRequest
    {

        /// <summary>
        /// 详细地址
        /// </summary>
        [ApiField("address")]
        public string Address { get; set; }

        /// <summary>
        /// 地域编码
        /// </summary>
        [ApiField("area_code")]
        public int AreaCode { get; set; }

    }
}
