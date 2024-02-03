
using Microsoft.AspNetCore.Mvc;

using Shared.form;
using Shared.ketnoi;

namespace duanxetnghiem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly Iaccount _authService;

        public AccountsController(Iaccount authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] loginform model)
        {
            var result = await _authService.Login(model);
            if (result!=null)
                return Ok(result);

            return BadRequest(result);
        }

       
    }
}
