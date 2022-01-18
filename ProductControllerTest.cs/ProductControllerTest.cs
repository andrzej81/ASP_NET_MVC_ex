using Microsoft.AspNetCore.Mvc;
//using System.Web.Mvc;
using WebApplication1.Controllers;
using WebApplication1.Models;
using Xunit;

namespace StoreTests.Controllers
{
    public class ProductControllerTest
    {
        [Fact]
        public void TestDetailsViewData()
        {
            var controller = new ProductController();
            var result = controller.Details(2) as ViewResult;
            var product = (Product)result.ViewData.Model;
            Assert.Equal("Laptop", product.Name);

        }
        [Fact]
        public void TestDetailsRedirect()
        {
            var controller = new ProductController();
                 
            var result = (RedirectToActionResult) controller.Details(-1);
            Assert.Equal("Index", result.ActionName);

        }

    }
}