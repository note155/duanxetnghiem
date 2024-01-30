using duanxetnghiem.Data.Model;
using duanxetnghiem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BacSiController : ControllerBase
    {
        private readonly IBacSi _BacSiRepository;
        public BacSiController(IBacSi BacSiRepository)
        {
            this._BacSiRepository = BacSiRepository;
        }
        [HttpGet("All-BacSi")]
        public async Task<ActionResult<List<BacSi>>> GetAllBacSiAsync()
        {
            var users = await _BacSiRepository.getallAsync();
            return Ok(users);
        }


        [HttpGet("Single-BacSi/{id}")]
        public async Task<ActionResult<BacSi>> GetSingleBacSitAsync(int id)
        {
            var student = await _BacSiRepository.getbyid(id);

            return Ok(student);
        }

        [HttpPost("Add-BacSi")]
        public async Task<ActionResult<BacSi>> AddNewBacSiAsync(BacSi user)
        {
            var newstudent = await _BacSiRepository.addAsync(user);

            return Ok(newstudent);
        }


        [HttpDelete("Delete-BacSi/{id}")]
        public async Task<ActionResult<BacSi>> DeleteBacSiAsync(int id)
        {
            var deletestudent = await _BacSiRepository.deleteAsync(id);

            return Ok(deletestudent);
        }


        [HttpPost("Update-BacSi")]
        public async Task<ActionResult<BacSi>> UpdateBacSiAsync(BacSi user)
        {
            var updatestudent = await _BacSiRepository.updateAsync(user);

            return Ok(updatestudent);
        }
    }

}
