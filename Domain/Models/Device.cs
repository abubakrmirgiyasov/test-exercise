using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Device
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = "";

        [MaxLength(255)]
        public string Description { get; set; } = "";

        public ICollection<Sensor> Sensors { get; set; }
    }
}
