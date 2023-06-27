using Microsoft.EntityFrameworkCore;
using WebApplicationApi.Model;

namespace WebApplicationApi.DataAccess
{
    public class FixtureDA
    {
        AppDbContext _appDbContext;
        public FixtureDA(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Fixture> GetAllFixture()
        {
            return _appDbContext.Fixtures.ToList();
        }

        public void AddFixture(Fixture fixture)
        {
            _appDbContext.Set<Fixture>().Add(fixture);
            _appDbContext.SaveChanges();
        }

        public List<Fixture> GetFixtures()
        {
            return _appDbContext.Set<Fixture>().ToList();
        }

    }
}
