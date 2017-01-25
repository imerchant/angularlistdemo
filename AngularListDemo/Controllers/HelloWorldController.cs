using System;
using System.Web.Http;

namespace AngularListDemo.Controllers
{
    [RoutePrefix("api")]
    public class HelloWorldController : ApiController
    {
        [HttpGet, Route("hello/{world}")]
        public IHttpActionResult Hello(string world)
        {
            return Ok(new
            {
                world,
                now = DateTime.Now
            });
        }
    }
}