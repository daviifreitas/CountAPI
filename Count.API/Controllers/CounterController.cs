using Count.API.Context;
using Count.API.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace Count.API.Controllers
{
    public class CounterController : Controller
    {

        private readonly CountAPIDbContext _context;

        public CounterController(CountAPIDbContext context)
        {
            _context = context;
        }

        // iF any person is present in the arduino's range which will be sent 1 or 0 if this condition is false;
        [Route("api/{id}")]
        [HttpPost]
        public IActionResult ReceivePersonPresence(int id)
        {
            if(id == 1)
            {
                CountModel countModelForAdd = new CountModel
                {
                    Id = new Random().Next(1000, 1000000),
                    Created_at = DateTime.Now
                };
                _context.CountModels.Add(countModelForAdd);
                _context.SaveChanges();

                return StatusCode(200);
            }
            return null; 
        }
        [HttpGet("getValues/")]
        public IActionResult SentAmountOfPerson()
        {
            int amount = _context.CountModels.Count();

            return new JsonResult(amount);
        }

    }
}
