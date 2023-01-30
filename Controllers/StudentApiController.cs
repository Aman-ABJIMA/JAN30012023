using Microsoft.AspNetCore.Mvc;
using Student_WEB_API.Model;
using Student_WEB_API.Repository;

namespace Student_WEB_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentApiController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
       
        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody]Student student)
        {
            var rollno = await _studentRepository.AddStudentAsync(student);
            return CreatedAtAction(nameof(GetStudentByRollNo), new { rollno = rollno, controller = "StudentApi" }, rollno);
        }
        [HttpGet("{rollno}")]

        public async Task<IActionResult> GetStudentByRollNo([FromRoute] int rollno)
        {
            var student = await _studentRepository.GetStudentByRollNoAsync(rollno);
            if (student == null)
                return NotFound();
            return Ok(student);
        }
    }
}
