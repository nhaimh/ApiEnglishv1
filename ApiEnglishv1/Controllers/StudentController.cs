using ApiEnglishv1.Models;
using ApiEnglishv1.Services.StudentServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEnglishv1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _studentServices;
        public StudentController(IStudentServices StudentServices)
        {
            _studentServices = StudentServices;
        }
        [HttpGet("student")]
        public async Task<ActionResult<List<Student>>> GetAllStu(int id)
        {
            var student = await _studentServices.GetAllStu(id);
            return student;
        }
        //public async Task<ActionResult<List<Student>>> CreateStu(Student student)
        //{
        //    return await _studentServices.CreateStu(student);
        //}
    }
}
