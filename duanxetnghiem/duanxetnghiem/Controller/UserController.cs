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

        [HttpGet("EmailExists/{email}")]
        public async Task<IActionResult> IsEmailExistsAsync(string email)
        {
            var isEmailExists = await _UserRepository.IsEmailExistsAsync(email);

            return Ok(isEmailExists);
        }
        [HttpPost("Add-User")]
        public async Task<ActionResult<int>> AddNewStudentAsync(User user)
        {
            var newUserId = await _UserRepository.adduserAsync(user);

            if (newUserId != -1)
            {
                return Ok(newUserId);
            }
            else
            {
                return BadRequest("Failed to add user.");
            }
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
