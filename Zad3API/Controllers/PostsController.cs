using Microsoft.AspNetCore.Mvc;
using System;
using Zad3API.Model;

namespace Zad3API.Controllers
{
    [Produces("application/json")]
    [Route("api/Posts")]
    public class PostsController : Controller
    {
        private Post post = new Post(new Author("firstUser", "Tester", new Uri("https://i.redd.it/rm6sqwpmesb41.jpg"), "TestUserSignature"), "testPost");

        // GET: api/Posts
        [HttpGet]
        public Post Get()
        {
            return post;
        }

        // GET: api/Posts/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Posts
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Posts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}