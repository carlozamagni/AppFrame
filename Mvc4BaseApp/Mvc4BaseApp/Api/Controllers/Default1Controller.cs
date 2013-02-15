using Mvc4BaseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mvc4BaseApp.Api.Controllers
{
    public class Default1Controller : ApiController
    {
        private ISampleModel _model;

        public Default1Controller(ISampleModel model)
        {
            _model = model;
        }


        // GET api/default1
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", ((SampleModel)_model).Status };
        }

        // GET api/default1/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/default1
        public void Post([FromBody]string value)
        {
        }

        // PUT api/default1/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/default1/5
        public void Delete(int id)
        {
        }
    }
}
