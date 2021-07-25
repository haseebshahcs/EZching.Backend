using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZching.Models.SystemConfiguration
{
    public class SystemConfigReqDTO
    {
        [Required]
        public string KeyName { get; set; }
    }
}
