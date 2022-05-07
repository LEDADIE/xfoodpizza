using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;

using xfoodpizza.Data;
using xfoodpizza.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace xfoodpizza.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        private DataContext _dataContext;

        public ApiController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // GET:<ApiController>
        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            var pizzas = _dataContext.Pizzas.ToList();

            return Json(pizzas);
        }
    }
}