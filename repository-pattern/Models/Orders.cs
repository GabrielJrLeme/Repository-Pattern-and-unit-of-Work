using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repository_pattern.Models
{
    public class Orders
    {

        public int Id { get; set; }

        public string Number { get; set; }

        public int CostumerId { get; set; }

        public Costumers Costumer { get; set; }
    }
}
