using EZching.Models.SystemConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZching.IRepository.SystemConfiguration
{
    public interface ISystemConfig
    {
        Task<dynamic> GetSystemConfig(SystemConfigReqDTO request);
    }
}
