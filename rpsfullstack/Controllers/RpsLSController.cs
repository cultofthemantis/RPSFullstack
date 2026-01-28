using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rpsfullstack.Controllers;

namespace rpsfullstack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RpsLSController : ControllerBase
    {
        private readonly RpsLSService _service;

        public RpsLSController (RpsLSService service)
        {
            _service = service;
        }


        [HttpGet ("CPU")]
        public string Game([FromQuery] string userMove)
        {
            return _service.Game(userMove.ToLower());
        }
   [HttpGet("pvp")]
    public string PVP(
        [FromQuery] string player1Move,
        [FromQuery] string player2Move
    )
    {
        return _service.PVP(
            player1Move.ToLower(),
            player2Move.ToLower()
        );
    }}
}