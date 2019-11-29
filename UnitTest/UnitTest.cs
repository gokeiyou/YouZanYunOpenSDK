using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Diagnostics;
using YouZan.Open.Api;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Request.Salesman;
using YouZan.Open.Api.Entry.Request.Ump;
using YouZan.Open.Api.Entry.Request.Users;
using YouZan.Open.Log;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        private static string clientId = "client_id";
        private static string clientSecret = "client_secret";
        private static string grantId = "grant_id";
        private static ApiHelper api = null;

        static UnitTest()
        {
            api = new ApiHelper(clientId, clientSecret, grantId);
        }

        [TestMethod]
        public void AllTest()
        {
            this.TestUserCheck();
            this.TestItemsOnsaleGet();
            this.TestSalesmanAccountAdd();
        }

        [TestMethod]
        public void TestUserCheck()
        {
            UsersAccountCheckRequest request = new UsersAccountCheckRequest();
            request.AccountType = "Mobile";
            request.AccountId = "13333333333";
            var response = api.UsersAccountCheck(request);
            Debug.WriteLine(JsonConvert.SerializeObject(response));
        }

        [TestMethod]
        public void TestItemsOnsaleGet()
        {
            var request = new YouZanRequest();
            var response = api.ItemsOnsaleGet(request);
            Debug.WriteLine(JsonConvert.SerializeObject(response));
        }

        [TestMethod]
        public void TestSalesmanAccountAdd()
        {
            var request = new SalesmanAccountAddRequest();
            request.Mobile = "13333333333";
            request.FansType = 0;
            request.FansId = 0;
            var response = api.SalesmanAccountAdd(request);
            Debug.WriteLine(JsonConvert.SerializeObject(response));
        }

        [TestMethod]
        public void TestUmpCouponSearch()
        {
            YouZanLogConfig.IsDBLog = false;
            var request = new UmpCouponSearchRequest();
            request.PageNo = 1;
            request.PageSize = 50;
            var respponse = api.UmpCouponSearch(request);
        }
        [TestMethod]
        public void TestUmpCouponTake()
        {
            YouZanLogConfig.IsDBLog = false;
            var request = new UmpCouponTakeRequest();
            request.Mobile = 15068135451;
            request.CouponGroupId = 6264402;
            var respponse = api.UmpCouponTake(request);
        }

        [TestMethod]
        public void TestUserWeiXinOpenIdGet()
        {
            var request = new UserWeiXinOpenIdGetRequest();
            request.Mobile = "15068135451";
            request.WechatType = 2;
            var response = api.UserWeiXinOpenIdGet(request);
        }
    }
}
