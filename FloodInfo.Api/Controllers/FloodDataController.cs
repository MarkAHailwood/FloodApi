using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FloodInfo.Api.Flood;
using FloodInfo.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FloodInfo.Api.Controllers
{
    [ApiController]
    [Route("{searchCritera}")]
    public class FloodDataController : ControllerBase
    {
        private readonly IFloodServices _floodData;

        public FloodDataController(IFloodServices floodData)
        {
            _floodData = floodData;
        }

        [HttpGet]
        public async Task<IActionResult> GetFloodData(string searchCritera)
        {
            var result = await _floodData.GetFloodData(searchCritera);

            return Ok(result);
        }
    }
}
