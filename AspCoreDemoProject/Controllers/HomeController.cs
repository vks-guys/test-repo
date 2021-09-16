using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreDemoProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreDemoProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStudentRepository _IStudentRepository;
        public HomeController(IStudentRepository iStudentRepository)
        {
            _IStudentRepository = iStudentRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //throw new Exception("5000");
            //var result = _IStudentRepository.GetStudent();
            //return View(result);
            return Ok(_IStudentRepository.GetStudent());
            //return View();
        }

        [HttpGet]
        [Route("{Id:int?}")]
        public IActionResult Index(int Id)
        {
            var result = _IStudentRepository.GetStudent().FirstOrDefault(a => a.Id == Id);
            if (result is null)
            {
                return NotFound($"Not Found with above id = {Id}");
            }
            return Ok(result);
        }
    }
}