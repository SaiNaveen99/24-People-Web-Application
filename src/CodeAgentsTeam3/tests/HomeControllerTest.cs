using CodeAgentsTeam3.Controllers;
using CodeAgentsTeam3.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CodeAgentsTeam3.tests
{
    public class HomeControllerTest
    {
        // use dependency injection - create a local IServiceProvider
        private readonly IServiceProvider _serviceProvider;

        // create a constructor to configure services
        public HomeControllerTest()
        {
            var efServiceProvider = new ServiceCollection();
            var services = new ServiceCollection();

            services.AddEntityFramework()
            .AddInMemoryDatabase()
            .AddDbContext<ApplicationDbContext>(
options => options.UseInMemoryDatabase());

            _serviceProvider = services.BuildServiceProvider();
        }

        [Fact]
        public void About_CreatesView()
        {  // return type is void not async task

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController();  // home controller doesn't use dbcontext

            // Act
            var result = controller.About(); // controller uses sync methods (not async)

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotNull(viewResult.ViewData);

        }

        [Fact]
        public void Contact_CreatesViewWithMessage()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController();

            // Act
            var result = controller.Contact();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.Same("Your contact page.", viewResult.ViewData["Message"]);

        }

  }
}
