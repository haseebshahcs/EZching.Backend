using AutoMapper;
using EZching.IRepository.SystemConfiguration;
using EZching.Models.SystemConfiguration;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EZching.Api.Controllers.SystemConfiguration
{
    [EnableCors("AllowOrigin")]
    [Route("EZching/[controller]")]
    [ApiController]
    public class SystemConfigController : ControllerBase
    {
        private readonly ISystemConfig _systemConfig;
        private readonly IMapper _mapper;
        public SystemConfigController(ISystemConfig systemConfig, IMapper mapper)
        {
            _systemConfig = systemConfig;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("GetSystemConfiguration")]
        public async Task<ActionResult> GetSystemConfiguration(SystemConfigReqDTO request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var data = await _systemConfig.GetSystemConfig(request);
                var model = _mapper.Map<SystemConfigResDTO>(data);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error :" + ex.Message);
            }
        }
    }
}
