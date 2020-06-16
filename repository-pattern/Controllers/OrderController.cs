using Microsoft.AspNetCore.Mvc;
using repository_pattern.Data.Interface;
using repository_pattern.Models;
using repository_pattern.Repositories;
using repository_pattern.Repositories.Interfaces;

namespace repository_pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        [HttpPost]
        [Route("")]
        public Orders Post(
            [FromServices] ICostumeRepository costumeRepository, 
            [FromServices] IOrdeRepository ordeRepository,
            [FromServices] IUnitOfWork unit)
        {
            try
            {
                var costumer = new Costumers() { Name = "joao" };

                var order = new Orders() { Number = "123", Costumer = costumer };

                costumeRepository.Save(costumer);
                ordeRepository.Save(order);

                unit.Commit();

                return order;
            }
            catch
            {
                unit.Rollback();
                return null;
            }
        }
        
    }
}