using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repository_pattern.Data.Interface
{
    public interface IUnitOfWork
    {

        void Commit();

        void Rollback();

    }
}
