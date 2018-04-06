using DataLayer;
using System.Collections.Generic;
using System.Web.Http;

namespace OurBookshelf.Controllers
{
    public class BooksController : ApiController
    {
        // GET: api/Books
       
        public List<Book> Get()
        {
            var books = new Books();
            var results = books.GetBooks();

            return results;

        }

        // GET: api/Books/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Books
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Books/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Books/5
        public void Delete(int id)
        {
        }
    }
}
