using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client.Services
{
    public class TcpSender
    {
        private const int PORT = 8000;
        private static TcpClient _client;

        public TcpSender()
        {
            _client = new TcpClient("127.0.0.1", PORT);
        }

        public void SendDeviceData(string header, string name, string description)
        {
            try
            {
                using (var network = _client.GetStream())
                {
                    using (var writer = new BinaryWriter(network))
                    {
                        var deviceId = Guid.NewGuid().ToString();

                        writer.Write(header);
                        writer.Write(deviceId);
                        writer.Write(name);
                        writer.Write(description);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void SendSensorData(string header, string name, string description, Guid deviceId)
        {
            try
            {
                using (var network = _client.GetStream())
                {
                    using (var writer = new BinaryWriter(network))
                    {
                        var sensorId = Guid.NewGuid().ToString();

                        writer.Write(header);
                        writer.Write(sensorId);
                        writer.Write(name);
                        writer.Write(description);
                        writer.Write(new Random().Next(1, 101).ToString());
                        writer.Write(deviceId.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void SendGeneratedData(string header)
        {
            try
            {
                using (var network = _client.GetStream())
                {
                    using (var writer = new BinaryWriter(network))
                    {
                        var sensorValueId = Guid.NewGuid().ToString();

                        writer.Write(header);
                        writer.Write(sensorValueId);
                        writer.Write(DateTime.Now.ToString());
                        writer.Write(new Random().Next(1, 101).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public List<ViewModel> GetCurrentDataList(string header)
        {
            try
            {
                using (var network = _client.GetStream())
                {
                    using (var writer = new BinaryWriter(network))
                    {
                        writer.Write(header);

                        var binary = new BinaryFormatter();
                        var data = (List<ViewModel>)binary.Deserialize(network);

                        return data;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public List<DeviceViewModel> GetDeviceList(string header)
        {
            try
            {
                using (var network = _client.GetStream())
                {
                    using (var writer = new BinaryWriter(network))
                    {
                        writer.Write(header);

                        var binary = new BinaryFormatter();
                        var data = (List<DeviceViewModel>)binary.Deserialize(network);

                        return data;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public List<ViewModel> GetFilteredDataList(string header, string device, DateTime topDate, DateTime bottomDate)
        {
            try
            {
                using (var network = _client.GetStream())
                {
                    using (var writer = new BinaryWriter(network))
                    {
                        writer.Write(header);
                        writer.Write(device);
                        writer.Write(topDate.ToString());
                        writer.Write(bottomDate.ToString());

                        var binary = new BinaryFormatter();
                        var data = (List<ViewModel>)binary.Deserialize(network);

                        return data;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
