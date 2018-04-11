using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    public class BorrowsController : Controller
    {
        [HttpGet("{id}")]
        public IEnumerable<string> Get(int id)
        {
            return new string[] {"Opowiesci z Narni", "Wiedzmin"};
        }
    }
}