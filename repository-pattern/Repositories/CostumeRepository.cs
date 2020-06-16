using repository_pattern.Data;
using repository_pattern.Models;

namespace repository_pattern.Repositories
{
    public class CostumeRepository : ICostumeRepository
    {

        private readonly DataContext _context;

        public CostumeRepository(DataContext context)
        {
            _context = context;
        }


        public void Save(Costumers costumer)
        {
            _context.Costumers.Add(costumer);
        }
    }
}
