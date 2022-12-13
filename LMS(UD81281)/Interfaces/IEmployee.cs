using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_UD81281_.Models;



namespace LMS_UD81281_.Interfaces
{
    public interface IEmployee
    {
        Task<List<Employee>> GetEmployees();
        Task<int> AddEmployees(Employee employees);
        Task<int> UpdateEmployees(int id, Employee employees);
        Task<int> DeleteEmployees(int id);
    }
}