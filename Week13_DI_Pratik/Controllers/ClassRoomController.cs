using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week13_DI_Pratik.Managers;

namespace Week13_DI_Pratik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly ClassRoom _classRoom;
        
        public ClassRoomController(ClassRoom classRoom)
        {
            _classRoom=classRoom;

        }

        [HttpGet("teacher-info")]
        public IActionResult GetTeacherInfo()
        {
            return Ok(_classRoom.GetTeacherInfo());
        }
    }
}
