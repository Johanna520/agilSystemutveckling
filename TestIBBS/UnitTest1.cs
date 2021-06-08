using Microsoft.VisualStudio.TestTools.UnitTesting;
using IBBS.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using IBBS;
using IBBS.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System.Collections.Generic;

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
            [TestMethod]
        public async void TestMethod1()
        {

            using var scope = _factory.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<BurgerDbContext>();
            var um = scope.ServiceProvider.GetRequiredService<UserManager<Users>>();

            var stringContent = new FormUrlEncodedContent(new[]
{
            new KeyValuePair<string, string>("UserName", "user1"),
});
            Assert.IsFalse(await um.FindByNameAsync("user1") == null);
            var client = _factory.CreateClient();
            var bucket = await client.PostAsync("/userlist", stringContent);
            Assert.IsTrue(bucket.IsSuccessStatusCode);
            Assert.IsTrue(await um.FindByNameAsync("user1") == null);
        }
    }
}
