using repository_pattern.Data;
using repository_pattern.Models;
using repository_pattern.Repositories.Interfaces;

namespace repository_pattern.Repositories
{
    public class OrdeRepository : IOrdeRepository
    {

        private readonly DataContext _context;

        public OrdeRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Orders order)
        {
            _context.Orders.Add(order);
        }
    }
}
