using Microsoft.AspNetCore.Mvc;
using Parcial.Common.Application.Dto;
using System;

namespace Parcial.Common.Controllers
{
    [Produces("application/json")]
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public Object Get()
        {
            return new ApiStringResponseDto("api rpg game");
        }
    }
}
