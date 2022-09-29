using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class SensorValue
    {
        [Key]
        public Guid Id { get; set; }

        public int ImmidiateValue { get; set; }

        public DateTime GenerationDate { get; set; }

        public Guid SensorId { get; set; }

        public Sensor Sensor { get; set; }
    }
}
