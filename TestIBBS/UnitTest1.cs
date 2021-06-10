using Microsoft.VisualStudio.TestTools.UnitTesting;
using IBBS.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using IBBS;
using IBBS.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TESTIBBS
{
    [TestClass]
    public class UnitTest1
    {
            private static WebApplicationFactory<Startup> _factory;

            [ClassInitialize]
            public static void ClassInit(TestContext testContext)
            {
                _factory = new WebApplicationFactory<Startup>();

            }



        [ClassCleanup]
        public static void ClassCleanupTest()
        {
            _factory.Dispose();
        }

        private IServiceScope _scope;

        //private BurgerDbContext DB;
        private UserManager<Users> user;
        private HttpClient client;

        [TestInitialize]
        public void InitTests()

        {
            _scope = _factory.Services.CreateScope();
           // DB = _scope.ServiceProvider.GetRequiredService<BurgerDbContext>();
            user = _scope.ServiceProvider.GetRequiredService<UserManager<Users>>();
            client = _factory.CreateClient();
        }


        [TestMethod]
        public async Task TestMethod1()
        {

            var values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("UserName", "User"));

            var stringContent = new FormUrlEncodedContent(values);


            Assert.IsFalse(await user.FindByNameAsync("User") != null);

            var bucket = await client.PostAsync("/userlist", stringContent);

            Assert.IsTrue(bucket.IsSuccessStatusCode);

            Assert.IsTrue(await user.FindByNameAsync("User") == null);
        }

    }
}
