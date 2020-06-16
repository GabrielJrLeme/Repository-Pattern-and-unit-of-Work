using repository_pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repository_pattern.Repositories.Interfaces
{
    public interface IOrdeRepository
    {

        void Save(Orders order);

    }
}
