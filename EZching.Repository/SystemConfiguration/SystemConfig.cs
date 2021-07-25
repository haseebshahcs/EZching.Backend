using EZching.Data.Entities;
using EZching.IRepository.SystemConfiguration;
using EZching.Models.SystemConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZching.Repository.SystemConfiguration
{
    public class SystemConfig : ISystemConfig
    {
        public async Task<dynamic> GetSystemConfig(SystemConfigReqDTO request)
        {
            object obj = null;
            try
            {
                using var db = new EZChingContext();
                obj = await db.SystemConfigs.FirstOrDefaultAsync(s => s.KeyName.ToUpper() == request.KeyName.ToUpper());
            }
            catch (Exception)
            {
                throw;
            }
            return obj;
        }
    }
}
