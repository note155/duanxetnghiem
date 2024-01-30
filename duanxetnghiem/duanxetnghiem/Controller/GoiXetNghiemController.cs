using duanxetnghiem.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoiXetNghiemController : ControllerBase
    {
        private readonly IGoiXetNghiem _GXNRepository;
        public GoiXetNghiemController(IGoiXetNghiem GXNRepository)
        {
            this._GXNRepository = GXNRepository;
        }
        [HttpGet("All-GXN")]
        public async Task<ActionResult<List<GoiXetNghiem>>> GetAllStudentsAsync()
        {
            var users = await _GXNRepository.getallAsync();
            return Ok(users);
        }


        [HttpGet("Single-GXN/{id}")]
        public async Task<ActionResult<GoiXetNghiem>> GetSingleStudentAsync(int id)
        {
            var student = await _GXNRepository.getbyid(id);

            return Ok(student);
        }

        [HttpPost("Add-GXN")]
        public async Task<ActionResult<GoiXetNghiem>> AddNewStudentAsync(GoiXetNghiem user)
        {
            var newstudent = await _GXNRepository.addAsync(user);

            return Ok(newstudent);
        }


        [HttpDelete("Delete-GXN/{id}")]
        public async Task<ActionResult<GoiXetNghiem>> DeleteStudentAsync(int id)
        {
            var deletestudent = await _GXNRepository.deleteAsync(id);

            return Ok(deletestudent);
        }


        [HttpPost("Update-GXN")]
        public async Task<ActionResult<GoiXetNghiem>> UpdateStudentAsync(GoiXetNghiem user)
        {
            var updatestudent = await _GXNRepository.updateAsync(user);

            return Ok(updatestudent);
        }
    }
}
