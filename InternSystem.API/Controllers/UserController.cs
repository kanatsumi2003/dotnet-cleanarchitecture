using InternSystem.Application.Features.User.Commands;
using InternSystem.Application.Features.User.Models;
using InternSystem.Application.Features.User.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InternSystem.API.Controllers
{
    [ApiController]
    [Route("api/v1/user")]
    public class UserController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<GetAllUserResponse>> GetAllUser() {
            var user = await Mediator.Send(new GetAllUserQuery());
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<GetUserDetailResponse>> CreateUser([FromBody] CreateUserCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
