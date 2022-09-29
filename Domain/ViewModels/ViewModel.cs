using System;

namespace Domain.ViewModels
{
    [Serializable]
    public class ViewModel
    {
        public string Device { get; set; } = "";

        public string Sensor { get; set; } = "";

        public DateTime Date { get; set; }

        public int Value { get; set; }
    }
}
