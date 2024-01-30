using duanxetnghiem.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ketnoi;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _UserRepository;
        public UserController(IUser UserRepository)
        {
            this._UserRepository = UserRepository;
        }
        [HttpGet("All-User")]
        public async Task<ActionResult<List<User>>> GetAllStudentsAsync()
        {
            var users = await _UserRepository.getalluserAsync();
            return Ok(users);
        }


        [HttpGet("Single-User/{id}")]
        public async Task<ActionResult<User>> GetSingleStudentAsync(int id)
        {
            var student = await _UserRepository.getuserbyid(id);

            return Ok(student);
        }

        [HttpPost("Add-User")]
        public async Task<ActionResult<User>> AddNewStudentAsync(User user)
        {
            var newstudent = await _UserRepository.adduserAsync(user);

            return Ok(newstudent);
        }


        [HttpDelete("DeleteUser/{id}")]
        public async Task<ActionResult<User>> DeleteStudentAsync(int id)
        {
            var deletestudent = await _UserRepository.deleteuserAsync(id);

            return Ok(deletestudent);
        }


        [HttpPost("Update-User")]
        public async Task<ActionResult<User>> UpdateStudentAsync(User user)
        {
            var updatestudent = await _UserRepository.updateuserAsync(user);

            return Ok(updatestudent);
        }
    }

}
