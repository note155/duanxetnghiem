using duanxetnghiem.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonXetNghiemController : ControllerBase
    {
        private readonly IDonXetNghiem _DXNRepository;
        public DonXetNghiemController(IDonXetNghiem DXNRepository)
        {
            this._DXNRepository = DXNRepository;
        }
        [HttpGet("All-DXN")]
        public async Task<ActionResult<List<DonXetNghiem>>> GetAllStudentsAsync()
        {
            var users = await _DXNRepository.getallAsync();
            return Ok(users);
        }


        [HttpGet("Single-DXN/{id}")]
        public async Task<ActionResult<DonXetNghiem>> GetSingleStudentAsync(int id)
        {
            var student = await _DXNRepository.getbyid(id);

            return Ok(student);
        }

        [HttpPost("Add-DXN")]
        public async Task<ActionResult<DonXetNghiem>> AddNewStudentAsync(DonXetNghiem user)
        {
            var newstudent = await _DXNRepository.addAsync(user);

            return Ok(newstudent);
        }


        [HttpDelete("Delete-DXN/{id}")]
        public async Task<ActionResult<DonXetNghiem>> DeleteStudentAsync(int id)
        {
            var deletestudent = await _DXNRepository.deleteAsync(id);

            return Ok(deletestudent);
        }


        [HttpPost("Update-DXN")]
        public async Task<ActionResult<DonXetNghiem>> UpdateStudentAsync(DonXetNghiem user)
        {
            var updatestudent = await _DXNRepository.updateAsync(user);

            return Ok(updatestudent);
        }
    }

}
