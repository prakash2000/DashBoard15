using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DashBoard15.DAL;
using DashBoard15.Models;

namespace DashBoard15.API
{
    public class MatchApiController : ApiController
    {
        AppContext db = new AppContext();

        // GET api/matchapi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/matchapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/matchapi
        public void Post(NewMatch match)
        {
            if (ModelState.IsValid)
            {
                db.Matches.Add(match);
                db.SaveChanges();
            }

        }

        // PUT api/matchapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/matchapi/5
        public void Delete(int id)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
