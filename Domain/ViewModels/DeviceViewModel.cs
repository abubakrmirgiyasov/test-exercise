using System;

namespace Domain.ViewModels
{
    [Serializable]
    public class DeviceViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
