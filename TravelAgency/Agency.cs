using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class Agency
    {

        public List<Employee> Employees { get; set; }
        public List<Hotel> Hotels { get; set; }
        private ILoadData _ILoadData;

        public Agency(ILoadData loadData)
        {
            _ILoadData = loadData;
            Employees = Task.Run(async () => await _ILoadData.LoadEmployeeData()).Result;
            Hotels = Task.Run(async () => await _ILoadData.LoadHotelData()).Result;
        }
    }

    public interface ILoadData
    {
        Task<List<Employee>> LoadEmployeeData();
        Task<List<Hotel>> LoadHotelData();
    }

    public class LoadData : ILoadData
    {
       public async Task<List<Employee>> LoadEmployeeData()
        {
            var employeeFilePath = await File.ReadAllTextAsync(@"../../../employees.json");
            var employeeData = JsonSerializer.Deserialize<List<Employee>>(employeeFilePath);
            return employeeData;
        }

        public async Task<List<Hotel>> LoadHotelData()
        {
            var hotelFilePath = await File.ReadAllTextAsync(@"../../../hotels.json");
            var hotelData = JsonSerializer.Deserialize<List<Hotel>>(hotelFilePath);
            return hotelData;
        }
    }
}
