using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewsReleaseSystem.Models;
using System.Linq;

namespace NewsReleaseSystem.Models.Tests
{
    [TestClass()]
    public class CofeDbContextTests
    {
        private CofeDbContext _context = new CofeDbContext();

        [TestMethod()]
        public void CofeDbContextTest()
        {
            Assert.AreEqual(0, _context.Comments.Count());
        }
    }
}