using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using CodeAgentsTeam3.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace CodeAgentsTeam3.Controllers
{
    public class DirectorsControllerTest : Controller
    {
        private readonly IServiceProvider _serviceProvider;
        private ApplicationDbContext dbContext;

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public DirectorsControllerTest()
        {
            var efServiceProvider = new ServiceCollection();
            var services = new ServiceCollection();
            services.AddEntityFramework().AddInMemoryDatabase().AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase());
            _serviceProvider = services.BuildServiceProvider();
        }



        [Fact]
        public void CodeAgentsTeam3_CreatesView()
        {
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new DirectorsController(dbContext);
            var result = controller.Create();
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotNull(viewResult.ViewData);
        }
        [Fact]
        public void CodeAgentsTeam3_DetailsViewReturn()
        {
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new DirectorsController(dbContext);
            var result = controller.Details(null);
            var viewResult = Assert.IsType<HttpNotFoundResult>(result);
            Assert.NotNull(viewResult);
        }

        [Fact]
        public void CodeAgentsTeam3_Delete()
        {
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new DirectorsController(dbContext);
            var result = controller.Delete(null);
            var viewResult = Assert.IsType<HttpNotFoundResult>(result);
            Assert.NotNull(viewResult);
        }
    }
}
