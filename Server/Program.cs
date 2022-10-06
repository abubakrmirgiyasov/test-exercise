using Domain.Models;
using Domain.ViewModels;
using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    public class Program
    {
        private const int PORT = 8080;
        private static TcpListener _listener = null;
        private static DataRepositories _repository = null;
        private static List<ViewModel> _viewModels = null;

        private static void Main(string[] args)
        {
            try
            {
                _repository = new DataRepositories();
                _viewModels = new List<ViewModel>();
                _listener = new TcpListener(IPAddress.Any, PORT);
                _listener.Start();

                Console.WriteLine("Ожидание подключений...");

                while (true)
                {
                    var client = _listener.AcceptTcpClient();

                    Console.WriteLine("Подключено успешно");

                    var network = client.GetStream();
                    var reader = new BinaryReader(network);

                    var header = reader.ReadString();
                    Console.WriteLine("Header: {0}", header);

                    if (header == "Device")
                    {
                        var deviceId = Guid.Parse(reader.ReadString());
                        var deviceName = reader.ReadString();
                        var decviceDescription = reader.ReadString();

                        var device = new Device()
                        {
                            Id = deviceId,
                            Name = deviceName,
                            Description = decviceDescription
                        };

                        _repository.AddDevice(device);

                        Console.WriteLine("Добавлено новое устройство");
                    }
                    else if (header == "GetDeviceList")
                    {
                        var devices = new List<DeviceViewModel>();
                        var formatter = new BinaryFormatter();

                        foreach (var item in _repository.GetDevices())
                        {
                            devices.Add(new DeviceViewModel()
                            {
                                Id = item.Id,
                                Name = item.Name,
                            });
                        }

                        Console.WriteLine($"Количетво устройств: {devices.Count}");

                        formatter.Serialize(network, devices);
                    }
                    else if (header == "Sensor")
                    {
                        var sensorId = Guid.Parse(reader.ReadString());
                        var sensorName = reader.ReadString();
                        var decviceDescription = reader.ReadString();
                        var sensorNum = int.Parse(reader.ReadString());
                        var deviceId = Guid.Parse(reader.ReadString());

                        var sensor = new Sensor()
                        {
                            Id = sensorId,
                            Name = sensorName,
                            Description = decviceDescription,
                            SensorNum = sensorNum,
                            DeviceId = deviceId,
                        };

                        _repository.AddSensor(sensor);

                        Console.WriteLine("Добавлено новое устройство");
                    }
                    else if (header == "SensorValue")
                    {
                        var sensorValues = new List<SensorValue>();

                        var sensorValueId = Guid.NewGuid();
                        var date = DateTime.Now;
                        var immidiateValue = new Random().Next(1, 101);
                        var sensorId = _repository.GetRandomSensor();

                        var sensorValue = new SensorValue()
                        {
                            Id = sensorValueId,
                            ImmidiateValue = immidiateValue,
                            GenerationDate = date,
                            SensorId = sensorId,
                        };

                        _repository.AddSensorValue(sensorValue);

                        Console.WriteLine("Добавлено новое устройство");

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
                    else if (header == "GetCurrentList")
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(network, _viewModels);

                        Console.WriteLine($"Добавлено: {_viewModels.Count}");
                    }
                    else if (header == "GetFilteredDataList")
                    {
                        var device = reader.ReadString();
                        var topDate = DateTime.Parse(reader.ReadString());
                        var bottomDate = DateTime.Parse(reader.ReadString());

                        var list = _repository.GetFilteredData(device, topDate, bottomDate);

                        var formatter = new BinaryFormatter();
                        formatter.Serialize(network, list);

                        Console.WriteLine($"Найдено: {list.Count}");
                    }
                    else if (header == "DrawObject")
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(network, _viewModels);
                    }

                    reader.Close();
                    network.Close();
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
