using CodeAgentsTeam3.Models;

namespace CodeAgentsTeam3.Controllers
{
    internal class ActressesController
    {
        private ApplicationDbContext dbContext;

        public ActressesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}