using System;

namespace Drawing.Services
{
    [Serializable]
    public class Objects
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int XAxis { get; set; }

        public int YAxis { get; set; }

        public int Size { get; set; }

        public int SensorValue { get; set; }

        public string Name { get; set; }

        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}
