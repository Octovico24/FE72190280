using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Blazor72190280.Models;

namespace Blazor72190280.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<Employee> Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/Employees");
            return result;
        }

        public async Task<Employee> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");
            return result;
        }

        public Task<Employee> Update(int id, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}