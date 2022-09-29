using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Sensor
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = "";

        [MaxLength(255)]
        public string Description { get; set; } = "";

        public int SensorNum { get; set; }

        public Guid DeviceId { get; set; }

        public Device Device { get; set; }

        public ICollection<SensorValue> SensorValues { get; set; }
    }
}
