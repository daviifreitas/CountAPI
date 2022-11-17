﻿using API.Context;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RegisterController : Controller
    {
        private ApplicationContext _context;

        public RegisterController(ApplicationContext context)
        {
            _context = context;
        }

        [Route("AddData")]
        [HttpGet]
        public IActionResult SendData()
        {
            for (int i =0;i < 9; i++)
            {
                Register register = new Register() { Created_at = DateTime.Now };
                _context.Registers.Add(register);
                _context.SaveChanges();
            }

            return StatusCode(200);
        }

        [HttpGet]
        [Route("getData")]
        public IActionResult GetData()
        {
            int amountOfData = _context.Registers.Count();
            return Json(new
            {
                Amount = amountOfData
            });
        }
    }
}
