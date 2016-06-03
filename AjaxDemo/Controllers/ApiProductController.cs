using AjaxDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AjaxDemo.Controllers
{
    public class ApiProductController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            return new Product[] {
                new Product() {Id=1, Name="LCD",Price=10000 }
                , new Product() {Id=2, Name="CPU",Price=90000 }};
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}