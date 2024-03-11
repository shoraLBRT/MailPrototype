using MailService.Models;
using MailWebApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MailWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRepository<User> _userRepository;
        public UsersController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }
    }
}
