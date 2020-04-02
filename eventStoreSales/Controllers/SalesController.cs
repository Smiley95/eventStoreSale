using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventTest.Repositories;
using System.Web.Http.Routing;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace eventTest.Controllers
{
    
    [ApiController]
    public class SalesController : ControllerBase
    {
        private EventRepository _repository = null;
        public SalesController()
        {
            this._repository = new EventRepository();
        }

        [HttpGet]
        //[Authorize(Roles = "director")]
        [Route("director/getAllSales")]
        public ActionResult<IEnumerable<JObject>> GetAllSales()
        {
            return Ok(_repository.GetSales()) ;
        }

        [HttpGet]
        //[Authorize(Roles = "director")]
        [Route("director/getToTalAmount")]
        public ActionResult<double> GetSalesTotalPrice()
        {
            return Ok(_repository.GetSalesTotalPrice());
        }

        [HttpGet]
        //[Authorize(Roles = "InventoryManager")]
        [Route("InventoryManager/getAll")]
        public ActionResult<IEnumerable<JToken>> GetInventory()
        {
            return Ok(_repository.GetInventory());
        }

        [HttpPost]
        //[Authorize(Roles = "saleman")]
        [Route("saleman/addSale")]
        public OkObjectResult AddSale([FromBody] Sale sale)
        {
            var savedSale = new Sale(sale.Quantity, sale.Product.Name, sale.Price);
            _repository.Save(sale);
            return Ok(sale);
        }
    }
}
