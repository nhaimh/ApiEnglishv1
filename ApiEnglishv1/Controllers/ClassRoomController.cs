using ApiEnglishv1.Models;
using ApiEnglishv1.Services.ClassRoomServices;
using ApiEnglishv1.Services.StudentServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEnglishv1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly IClassRoomServices _classRoomServices;
        public ClassRoomController(IClassRoomServices ClassRoomServices)
        {
            _classRoomServices = ClassRoomServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<Classroom>>> GetAll()
        {
            var result = await _classRoomServices.GetAll();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);

            //return await _classRoomServices.GetAll();
        }
        [HttpPost]
        public async Task<ActionResult<List<Classroom>>> Create(Classroom classroom)
        {
            return await _classRoomServices.Create(classroom);
        }

        [HttpGet("id")]
        public async Task<ActionResult<Classroom>> GetById(int id)
        {
            return await _classRoomServices.GetById(id);
        }
        [HttpDelete("id")]
        public async Task<ActionResult<List<Classroom>>> Delete(int id)
        {
            return await _classRoomServices.Delete(id);
        }
        [HttpPut("id")]
        public async Task<ActionResult<List<Classroom>>> Update(int id, Classroom request)
        {
            return await _classRoomServices.Update(id, request);
        }
    }
}
