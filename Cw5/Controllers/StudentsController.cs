using System.Linq;
using Cw5.Services;
using Cw5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw5.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private static IDbStudentService _dbService;

        public StudentsController(IDbStudentService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_dbService.GetAllStudents());
        }

        [HttpGet("{idStudent}")]
        public IActionResult GetStudent([FromRoute] string idStudent)
        {
            var student = _dbService.GetStudent(idStudent);
            if (student == null) return NotFound($"Student with ID: {idStudent} not found!");
            return Ok(student);
        }
    }
}