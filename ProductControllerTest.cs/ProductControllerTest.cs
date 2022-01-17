using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;
using Xunit;

namespace StoreTests.Controllers
{
    public class ProductControllerTest
    {
        [Fact]
        public void TestDetailsView()
        {
            var controller = new ProductController();
            var result = controller.Details(2) as ViewResult;
            Assert.Equal("Details", result.ViewName);

        }
    }
}