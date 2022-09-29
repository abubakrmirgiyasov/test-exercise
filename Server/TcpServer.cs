using Domain.Models;
using Domain.ViewModels;
using Infrastructure.Services;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    public class TcpServer
    {
        private static TcpListener _listener = null!;
        private static DataRepositories _repository = null!;
        private List<ViewModel> _viewModels = null!;

        public TcpServer(int port)
        {
            _repository = new DataRepositories();
            _listener = new TcpListener(IPAddress.Any, port);

            _viewModels = new List<ViewModel>();
        }

        public void GetData()
        {
            try
            {
                _listener.Start();

                Console.WriteLine("Ожидание подключений...");

                while (true)
                {
                    var client = _listener.AcceptTcpClient();

                    if (client.Connected)
                    {
                        Console.WriteLine("Подключено успешно");

                        using var network = client.GetStream();
                        
                        if (network.DataAvailable)
                        {
                            AddData(network);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddData(NetworkStream network)
        {
            using var reader = new BinaryReader(network);

            var str = reader.ReadString();

            if (str == "Device")
            {
                var deviceId = Guid.Parse(reader.ReadString());
                var deviceName = reader.ReadString();
                var deviceDescription = reader.ReadString();

                var device = new Device()
                {
                    Id = deviceId,
                    Name = deviceName,
                    Description = deviceDescription,
                };

                _repository.AddDevice(device);

                Console.WriteLine("Добавлено новое устройство");
            }
            else if (str == "Sensor")
            {
                var sensorId = Guid.Parse(reader.ReadString());
                var sensorName = reader.ReadString();
                var sensorDescription = reader.ReadString();
                var sensorNum = int.Parse(reader.ReadString());
                var deviceId = Guid.Parse(reader.ReadString());

                var sensor = new Sensor()
                {
                    Id = sensorId,
                    Name = sensorName,
                    Description = sensorDescription,
                    SensorNum = sensorNum,
                    DeviceId = deviceId,
                };

                _repository.AddSensor(sensor);

                Console.WriteLine("Добавлен новый датчик");
            }
            else if (str == "SensorValue")
            {
                var sensorValues = new List<SensorValue>();

                var sensorValueId = Guid.Parse(reader.ReadString());
                var date = DateTime.Parse(reader.ReadString());
                var immidiateValue = int.Parse(reader.ReadString());
                var sensorId = _repository.GetRandomSensor();

                var sensorValue = new SensorValue()
                {
                    Id = sensorValueId,
                    ImmidiateValue = immidiateValue,
                    GenerationDate = date,
                    SensorId = sensorId,
                };

                _repository.AddSensorValue(sensorValue);

                sensorValues.Add(sensorValue);

                foreach (var item in sensorValues)
                {
                    var sensor = _repository.GetSensorById(sensorId);

                    _viewModels.Add(new ViewModel()
                    {
                        Device = sensor.Device.Name,
                        Sensor = sensor.Name,
                        Date = date,
                        Value = immidiateValue,
                    });
                }

                Console.WriteLine("Добавлено новое значение для датчика");
            }
            else if (str == "GetDeviceList")
            {
                var devices = new List<DeviceViewModel>();

                var formatter = new BinaryFormatter();

                foreach (var item in _repository.GetDevices())
                {
                    devices.Add(new DeviceViewModel()
                    {
                        Id = item.Id,
                        Name = item.Name
                    });
                }

                formatter.Serialize(network, devices);

                Console.WriteLine($"Количетво: {devices.Count}");
            }
            else if (str == "GetFilteredDataList")
            {
                var device = reader.ReadString();
                var topDate = DateTime.Parse(reader.ReadString());
                var bottomDate = DateTime.Parse(reader.ReadString());

                var list = _repository.GetFilteredData(device, topDate, bottomDate);

                var formatter = new BinaryFormatter();
                formatter.Serialize(network, list);

                Console.WriteLine($"Найдено: {list.Count}");
            }
            else if (str == "GetCurrentList")
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(network, _viewModels);

                Console.WriteLine($"Добавлено: {_viewModels.Count}");
            }
        }
    }
}
