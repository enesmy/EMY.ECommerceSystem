using EMY.ECommerceSystem.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EMY.ECommerceSystem.Tests.DatabaseRegistrationTests
{
    [TestClass]
    public class ShoppingTests
    {
        readonly ECommerceAPIDbContext _context;
        public ShoppingTests()
        {
            var options = new DbContextOptionsBuilder<ECommerceAPIDbContext>();
            options.UseInMemoryDatabase("Shopping");
            _context = new ECommerceAPIDbContext(options.Options);
        }

        public void CanConnect(){
            Assert.IsNotNull(_context);
            Assert.IsTrue(_context.Database.CanConnect());
        }


        [TestMethod]
        public void BasketRegistration()
        {
            Assert.IsNotNull(_context);
            Assert.IsTrue(_context.Database.CanConnect());



        }
    }
}
