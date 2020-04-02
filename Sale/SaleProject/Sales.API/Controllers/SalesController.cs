using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sales.API.Commands;
using Sales.Domain.AggregateModel.SaleAggregate;

namespace Sales.API.Controllers
{
    [ApiController]
    public class SalesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [Route("test/values")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [Route("test/values")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpDelete]
        [Route("saleman/cancelSale/{id:guid}")]
        public void CancelSale(Guid id)
        {
            var CommandHandler = new CancelSaleCommandHandler();
            CommandHandler.Handle(new CancelSaleCommand(id));
        }

        [HttpPost]
        [Route("saleman/saveSale")]
        public void saveSale([FromBody] Sale sale)
        {
            var CommandHandler = new SaveSaleCommandHandler();
            CommandHandler.Handle(new SaveSaleCommand(sale));
        }

        [HttpGet]
        [Route("InventoryManger/getInventoryDetails")]
        public void getInventoryDetails()
        {
        }

        [HttpGet]
        [Route("diector/getSales")]
        public void getSales()
        {
        }

    }
}
