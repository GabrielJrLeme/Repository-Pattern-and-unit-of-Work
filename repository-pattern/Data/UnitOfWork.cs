
using repository_pattern.Data.Interface;

namespace repository_pattern.Data
{
    public class UnitOfWork : IUnitOfWork
    {


        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }


        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            //
        }
    }
}
