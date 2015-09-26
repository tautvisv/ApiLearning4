using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dota2WebAPI.Controllers
{
    public class DotaController : ApiController
    {
        // GET api/dota
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/dota/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/dota
        public object Post([FromBody]string value)
        {
            return new {value};
        }

        // PUT api/dota/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/dota/5
        public void Delete(int id)
        {
        }

        public object MyPost(int id, [FromBody] object value)
        {
            return new { function = "MyPost(int id, [FromBody] string value)", val = value };
        }
        public object MyPost2(int id, [FromBody] object value)
        {
            return new { function = "MyPost2(int id, [FromBody] string value)", val = value };
        }
        [Route("api/Dota/MyPostas")]
        public object MyPosta([FromBody] object value)
        {
            return new { function = "MyPosta([FromBody] string value)", value };
        }
    }
}
