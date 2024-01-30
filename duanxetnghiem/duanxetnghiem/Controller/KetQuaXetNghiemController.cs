using duanxetnghiem.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class KetQuaXetNghiemController : ControllerBase
    {
        private readonly IKetQuaXetNghiem _KQXNRepository;
        public KetQuaXetNghiemController(IKetQuaXetNghiem KQXNRepository)
        {
            this._KQXNRepository = KQXNRepository;
        }
        [HttpGet("All-KQXN")]
        public async Task<ActionResult<List<KetQuaXetNghiem>>> GetAllStudentsAsync()
        {
            var users = await _KQXNRepository.getallAsync();
            return Ok(users);
        }


        [HttpGet("Single-KQXN/{id}")]
        public async Task<ActionResult<KetQuaXetNghiem>> GetSingleStudentAsync(int id)
        {
            var student = await _KQXNRepository.getbyid(id);

            return Ok(student);
        }

        [HttpPost("Add-KQXN")]
        public async Task<ActionResult<KetQuaXetNghiem>> AddNewStudentAsync(KetQuaXetNghiem user)
        {
            var newstudent = await _KQXNRepository.addAsync(user);

            return Ok(newstudent);
        }


        [HttpDelete("Delete-KQXN/{id}")]
        public async Task<ActionResult<KetQuaXetNghiem>> DeleteStudentAsync(int id)
        {
            var deletestudent = await _KQXNRepository.deleteAsync(id);

            return Ok(deletestudent);
        }


        [HttpPost("Update-KQXN")]
        public async Task<ActionResult<KetQuaXetNghiem>> UpdateStudentAsync(KetQuaXetNghiem user)
        {
            var updatestudent = await _KQXNRepository.updateAsync(user);

            return Ok(updatestudent);
        }
    }
}
