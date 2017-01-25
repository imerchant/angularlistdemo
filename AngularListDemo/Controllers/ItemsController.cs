using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using AngularListDemo.Services;

namespace AngularListDemo.Controllers
{
    [RoutePrefix("api")]
    public class ItemsController : ApiController
    {
        [HttpGet, Route("items")]
        public IHttpActionResult GetItems()
        {
            return Ok(ItemsService.Items);
        }

        [HttpPost, Route("items")]
        public IHttpActionResult SaveItem([FromBody] InputModel model)
        {
            var last = ItemsService.Items.LastOrDefault();

            var next = last == null ? 1 : last.Id + 1;

            var item = new Item {Id = next, Value = model.Input};
            ItemsService.SaveItem(item);
            return Ok(item);
        }

        [HttpDelete, Route("items/{id:int}")]
        public IHttpActionResult DeleteItem(int id)
        {
            ItemsService.DeleteItem(id);
            return Ok();
        }
    }

    public class InputModel
    {
        public string Input { get; set; }
    }
}