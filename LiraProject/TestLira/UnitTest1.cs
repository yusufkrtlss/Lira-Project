using EntityLayer.Concrete;
using LiraProject.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestLira
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Details_Returns_CompanySymbol()
        {
            //Arrange
            var controller = new CompanyController();
            var result = controller.Details("AAPL") as ViewResult;
            //Act
            var company = (Companies?)result?.ViewData.Model;
            //Assert
            Assert.Equal("AAPL", company?.CompanySymbol);
        }
    }
}