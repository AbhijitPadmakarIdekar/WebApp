using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Domain.Entities;
using WebApp.Domain.Repository;

namespace WebApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var usersFromRepo = _unitOfWork.User.GetAll();
            return Ok(usersFromRepo);
        }

        [HttpPost("RegisterUser")]
        public IActionResult RegisterUser([FromBody] User userCreds)
        {
            if ( userCreds == null )
            {
                return BadRequest("Invalid User!");
            }
            else
            {
                _unitOfWork.User.Add(userCreds);
            }
                        
            return Ok(new { Message = "User Created Successfully!"});
        }
    }
}
