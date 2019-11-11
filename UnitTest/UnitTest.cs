using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Diagnostics;
using YouZan.Open.Api;
using YouZan.Open.Api.Entry.Request;
using YouZan.Open.Api.Entry.Request.Salesman;
using YouZan.Open.Api.Entry.Request.Users;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        //private static string clientId = "client_id";
        //private static string clientSecret = "client_secret";
        //private static string grantId = "grant_id";
        //private static string clientId = "5a0785eda8c9d7ca05";
        //private static string clientSecret = "f2e9916e21b4c2cd8e349868b31a3ee6";
        //private static string grantId = "43389635";
        private static string clientId = "f6f29421eefd042be5";
        private static string clientSecret = "b3af16efee2058c28bb982f6d0c8a8c4";
        private static string grantId = "43704621";
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
            request.Mobile = "13588028599";
            request.FansType = 0;
            request.FansId = 0;
            var response = api.SalesmanAccountAdd(request);
            Debug.WriteLine(JsonConvert.SerializeObject(response));
        }
    }
}
