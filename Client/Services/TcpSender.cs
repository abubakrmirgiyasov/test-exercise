using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace Client.Services
{
    public class TcpSender
    {
        private const int PORT = 8080;
        private const string ADDRESS = "127.0.0.1";
        private static TcpClient _client = null;

        public TcpSender()
        {
            _client = new TcpClient();

            _client.Connect(ADDRESS, PORT);
        }

        public void SendDeviceObject(string header, string name, string description)
        {
            try
            {
                var network = _client.GetStream();
                var writer = new BinaryWriter(network);

                var deviceId = Guid.NewGuid().ToString();

                writer.Write(header);
                writer.Write(deviceId);
                writer.Write(name);
                writer.Write(description);
                writer.Flush();
                writer.Close();
                network.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void SendSensorObject(string header, string name, Guid deviceId, string description)
        {
            try
            {
                var network = _client.GetStream();
                var writer = new BinaryWriter(network);

                var sensorId = Guid.NewGuid().ToString();

                writer.Write(header);
                writer.Write(sensorId);
                writer.Write(name);
                writer.Write(description);
                writer.Write(new Random().Next(1, 101).ToString());
                writer.Write(deviceId.ToString());
                writer.Flush();
                writer.Close();
                network.Close();
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
                var network = _client.GetStream();
                var writer = new BinaryWriter(network);

                var sensorId = Guid.NewGuid().ToString();

                writer.Write(header);

                var formatter = new BinaryFormatter();
                var data = (List<DeviceViewModel>)formatter.Deserialize(network);

                writer.Flush();
                writer.Close();
                network.Close();

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void SendGeneratedObject(string header)
        {
            try
            {
                var network = _client.GetStream();
                var writer = new BinaryWriter(network);
                writer.Write(header);
                writer.Flush();
                writer.Close();
                network.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public List<ViewModel> GetCurrentList(string header)
        {
            try
            {
                var network = _client.GetStream();
                var writer = new BinaryWriter(network);

                writer.Write(header);
                writer.Flush();

                var formatter = new BinaryFormatter();
                var data = (List<ViewModel>)formatter.Deserialize(network);

                writer.Close();
                network.Close();

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public List<ViewModel> GetFilteredData(string header, string device, DateTime topDate, DateTime bottomDate)
        {
            try
            {
                var network = _client.GetStream();
                var writer = new BinaryWriter(network);

                writer.Write(header);
                writer.Write(device);
                writer.Write(topDate.ToString());
                writer.Write(bottomDate.ToString());
                writer.Flush();

                var formatter = new BinaryFormatter();
                var data = (List<ViewModel>)formatter.Deserialize(network);

                writer.Close();
                network.Close();

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public List<ViewModel> SendObject(string header)
        {
            try
            {
                var network = _client.GetStream();
                var writer = new BinaryWriter(network);

                writer.Write(header);
                writer.Flush();

                var formatter = new BinaryFormatter();
                var data = (List<ViewModel>)formatter.Deserialize(network);

                writer.Close();
                network.Close();

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
