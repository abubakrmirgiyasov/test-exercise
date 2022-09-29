using Domain.Models;
using Domain.ViewModels;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Services
{
    public class DataRepositories
    {
        private readonly ApplicationDbContext _context;

        public DataRepositories()
        {
            _context = new ApplicationDbContext();
        }

        public List<Device> GetDevices()
        {
            var devices = _context.Devices.ToList();
            return devices;
        }

        public List<SensorValue> GetSensorValues()
        {
            var list = _context.SensorValues
                .Include(x => x.Sensor)
                .ThenInclude(x => x.Device)
                .ToList();
            return list;
        }

        public Sensor GetSensorById(Guid id)
        {
            var sensor = _context.Sensors
                .Include(x => x.Device)
                .FirstOrDefault(x => x.Id == id);
            return sensor;
        }

        public void AddDevice(Device device)
        {
            try
            {
                _context.Devices.Add(device);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void AddSensor(Sensor sensor)
        {
            try
            {
                _context.Sensors.Add(sensor);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void AddSensorValue(SensorValue sensorValue)
        {
            try
            {
                _context.SensorValues.Add(sensorValue);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Guid GetRandomSensor()
        {
            var id = _context.Sensors
                .Select(x => x.Id)
                .ToList();
            var random = new Random().Next(id.Count());
            return id[random];
        }

        public List<ViewModel> GetFilteredData(string text, DateTime topDate, DateTime bottomDate)
        {
            try
            {
                var list = _context.SensorValues
                    .Include(x => x.Sensor)
                    .ThenInclude(x => x.Device)
                    .ToList();

                var viewModels = new List<ViewModel>();

                for (int i = 0; i < list.Count(); i++)
                {
                    viewModels.Add(new ViewModel
                    {
                        Device = list[i].Sensor.Device.Name,
                        Sensor = list[i].Sensor.Name,
                        Date = list[i].GenerationDate,
                        Value = list[i].ImmidiateValue,
                    });
                }

                viewModels = viewModels.Where(x => x.Device.IndexOf(text) != -1).ToList();
                viewModels = viewModels.Where(x => x.Date >= topDate && x.Date <= bottomDate).ToList();

                return viewModels;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
