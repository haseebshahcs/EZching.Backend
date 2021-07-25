using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EZching.Data.Entities
{
    [Table("SYSTEM_CONFIG")]
    public partial class SystemConfig
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("KEY_NAME")]
        [StringLength(100)]
        public string KeyName { get; set; }
        [Required]
        [Column("KEY_VALUE")]
        [StringLength(500)]
        public string KeyValue { get; set; }
        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }
        [Column("END_DATE")]
        public DateTime? EndDate { get; set; }
    }
}
